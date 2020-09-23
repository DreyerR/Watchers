using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
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

        public async static Task<bool> AuthUser(string email, string password) // Use this method to sign the user in.
        {
            client = GetHttpClient();

            AuthUserModel authUser = new AuthUserModel
            {
                email = email,
                pass = password
            };

            HttpResponseMessage response = await client.PostAsync(new Uri(AppConstants.AuthURL), ConvertToStringContent(authUser));

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                dynamic json = JsonConvert.DeserializeObject<dynamic>(content);

                return (json["isSuccessful"] == true) ? true : false;
            }
            else
            {
                throw new Exception("Connection not successful");
            }
           
        }

        private static StringContent ConvertToStringContent<T>(T model)
        {
            string json = JsonConvert.SerializeObject(model);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
