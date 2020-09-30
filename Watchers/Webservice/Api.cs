using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            //MessageBox.Show(authUser.password);

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
                throw new Exception("Error: Could not connect to remote server.\n Status code: " + response.StatusCode);
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
                throw new Exception("Error: Could not connect to remote server.\n Status code: " + response.StatusCode);
            }
        }

        private static StringContent ConvertToStringContent<T>(T model)
        {
            string json = JsonConvert.SerializeObject(model);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
