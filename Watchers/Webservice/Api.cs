using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using Watchers.Common;
using Watchers.Models;
using Watchers.Models.Post_Models;

namespace Watchers.Webservice
{
    class Api
    {
        private static HttpClient client;

        private static HttpClient GetHttpClient()
        {
            if (client == null)
            {
                client = new HttpClient();
            }
            return client;
        }

        public async static Task<bool> AuthUserAsync(string email, string password) // Use this method to sign the user in.
        {
            client = GetHttpClient();

            AuthUserPost authUser = new AuthUserPost
            {
                mode = 0,
                email = email,
                password = SHA.ToSHA256(password)
            };

            HttpResponseMessage response = await client.PostAsync(new Uri(AppConstants.AuthURL), ConvertToStringContent(authUser));

            if (response.IsSuccessStatusCode) // Status code = 200 (OK)
            {
                string content = await response.Content.ReadAsStringAsync();

                AuthUserResponse responseModel = JsonConvert.DeserializeObject<AuthUserResponse>(content);

                if (responseModel.IsSuccessful)  // Login was successfull
                {
                    Properties.Settings.Default.UserID = responseModel.UserID;
                    Properties.Settings.Default.Name = responseModel.Name;
                    Properties.Settings.Default.Surname = responseModel.Surname;
                    Properties.Settings.Default.Email = responseModel.Email;
                    Properties.Settings.Default.Save();

                    return true;
                }
                else
                {
                    return false;
                }              
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
           
        }

        public static async Task<bool> RegisterUserAsync(string name, string surname, string email, string password)
        {
            client = GetHttpClient();

            AuthUserPost registerModel = new AuthUserPost
            {
                mode = 1,
                name = name,
                surname = surname,
                email = email,
                password = SHA.ToSHA256(password),
                isAdmin = 0
            };

            HttpResponseMessage response = await client.PostAsync(new Uri(AppConstants.AuthURL), ConvertToStringContent(registerModel));

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                dynamic json = JsonConvert.DeserializeObject<dynamic>(content);

                if (json["isSuccessful"] == true)
                {
                    Properties.Settings.Default.UserID = json["userID"];
                    Properties.Settings.Default.Name = name;
                    Properties.Settings.Default.Surname = surname;
                    Properties.Settings.Default.Email = email;
                    Properties.Settings.Default.Save();

                    return true;
                }

                return false;
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
        }

        public async static Task<SeriesCollection> GetMovieCount()
        {
            client = GetHttpClient();

            string url = AppConstants.MovieURl + "?mode=2";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<MovieCountResponse> model = JsonConvert.DeserializeObject<List<MovieCountResponse>>(content);

                SeriesCollection series = new SeriesCollection();

                Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

                for (int i = 0; i < model.Count; i++)
                {
                    series.Add(new PieSeries() { Title = model[i].MovieName, Values = new ChartValues<int> { model[i].BookingCount }, DataLabels = true, LabelPoint = labelPoint });
                }

                return series;
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
        }

        public async static Task<DataTable> GetAllUsersAsync()
        {
            client = GetHttpClient();

            string url = AppConstants.UsersURL + "?mode=0"; // Sets the mode to 0.

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                GetUserResponse model = JsonConvert.DeserializeObject<GetUserResponse>(content);

                if (model.IsSuccessful)
                {
                    return BuildUserDataTable(model.Users);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
        }

        private static DataTable BuildUserDataTable(List<User> users)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add(new DataColumn("User ID", typeof(int)));
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Email Address");
            dt.Columns.Add(new DataColumn("Admin", typeof(bool)));

            for (int i = 0; i < users.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = users[i].UserID;
                dr[1] = users[i].Name;
                dr[2] = users[i].Surname;
                dr[3] = users[i].Email;
                dr[4] = users[i].IsAdmin;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        public async static Task<DataTable> GetAllBookingsAsync()
        {
            string url = AppConstants.BookingURL + "?mode=0";

            client = GetHttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                GetBookingsResponse model = JsonConvert.DeserializeObject<GetBookingsResponse>(content);

                if (model.IsSuccessful)
                {
                    return BuildBookingDataTable(model.Bookings);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
        }

        private static DataTable BuildBookingDataTable(List<Booking> bookings)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Ticket ID");
            dt.Columns.Add("Movie name");
            dt.Columns.Add("First name");
            dt.Columns.Add("Last name");
            dt.Columns.Add("Email");
            dt.Columns.Add(new DataColumn("Booking time", typeof(DateTime)));
            dt.Columns.Add("Seat number");
            dt.Columns.Add(new DataColumn("Seat quantity", typeof(int)));
            dt.Columns.Add("Total Price");

            for (int i = 0; i < bookings.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = bookings[i].TicketID;
                dr[1] = bookings[i].MovieName;
                dr[2] = bookings[i].FirstName;
                dr[3] = bookings[i].LastName;
                dr[4] = bookings[i].Email;
                dr[5] = bookings[i].BookingTime;
                dr[6] = bookings[i].SeatNumber;
                dr[7] = bookings[i].SeatQuantity;
                dr[8] = bookings[i].TotalPrice.ToString("C");
                dt.Rows.Add(dr);
            }

            return dt;
        }

        public static async Task<DataTable> GetOrdersAsync()
        {
            string url = AppConstants.OrderURL + "?mode=0";

            client = GetHttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                GetOrderResponse model = JsonConvert.DeserializeObject<GetOrderResponse>(content);

                if (model.IsSuccessful)
                    return BuildOrdersDataTable(model.Orders);
                else
                    return null;
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
        }

        private static DataTable BuildOrdersDataTable(List<Models.Order> orders)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Order ID");
            dt.Columns.Add("Ticket ID");
            dt.Columns.Add("Snack name");
            dt.Columns.Add("Snack quantity");
            dt.Columns.Add("Snack price");
            dt.Columns.Add("First name");
            dt.Columns.Add("Last name");
            dt.Columns.Add("Email");

            foreach (Models.Order order in orders)
            {
                DataRow dr = dt.NewRow();
                dr[0] = order.OrderID;
                dr[1] = order.TicketID;
                dr[2] = order.ProductName;
                dr[3] = order.SnackQuantity;
                dr[4] = order.ProductPrice.ToString("C");
                dr[5] = order.FirstName;
                dr[6] = order.LastName;
                dr[7] = order.Email;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        public static async Task<bool> UpdateUserAsync(int userID, string name, string surname, string email)
        {
            AuthUserPost model = new AuthUserPost
            {
                mode = 0,
                userID = userID,
                name = name,
                surname = surname,
                email = email,
                isAdmin = 0
            };

            client = GetHttpClient();

            HttpResponseMessage response = await client.PostAsync(AppConstants.UsersURL, ConvertToStringContent(model));

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject<dynamic>(content);

                return json["isSuccessful"];
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
        }

        public static async Task<bool> DeleteUserAsync(int userID)
        {
            Dictionary<string, int> keyValues = new Dictionary<string, int>();
            keyValues.Add("mode", 1);
            keyValues.Add("userID", userID);

            client = GetHttpClient();

            HttpResponseMessage response = await client.PostAsync(AppConstants.UsersURL, ConvertToStringContent(keyValues));

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject<dynamic>(content);

                return json["isSuccessful"];
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
        }

        public static async Task<dynamic> InsertBookingAsync(BookingPost booking)
        {
            client = GetHttpClient();
            booking.mode = 0;

            HttpResponseMessage response = await client.PostAsync(AppConstants.BookingURL, ConvertToStringContent(booking));

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Dictionary<string, dynamic> pairs = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(content);

                if (pairs["isSuccessful"])
                    return pairs;
                else
                    return false;
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
        }

        public static async Task<bool> DeleteBookingAsync(string ticketID)
        {
            Dictionary<string, dynamic> keys = new Dictionary<string, dynamic>();
            keys.Add("mode", 1);
            keys.Add("ticketID", ticketID);

            client = GetHttpClient();
            HttpResponseMessage response = await client.PostAsync(AppConstants.BookingURL, ConvertToStringContent(keys));

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject<dynamic>(content);

                return data["isSuccessful"];
            }
            else
            {
                throw new Exception("Error: Could not connect to remote server.\nStatus code: " + (int)response.StatusCode);
            }
        }

        private static StringContent ConvertToStringContent<T>(T model)
        {
            string json = JsonConvert.SerializeObject(model);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
