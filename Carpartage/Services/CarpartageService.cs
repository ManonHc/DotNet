using Modeles;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Carpartage.Services
{
    class CarpartageService
    {
           public async Task<IEnumerable<User>> GetUsers()
           {
               var clientHTTP = new HttpClient();
               var responseRequest = await clientHTTP.GetStringAsync(new Uri("http://webapicarpartage.azurewebsites.net/api/Users "));
               var rawUser = JArray.Parse(responseRequest);
               var users = rawUser.Children().Select(d => new User()
                {
                    Id = d["Id"].Value<int>(),
                    Name = d["Name"].Value<String>(),
                    Password = d["Password"].Value<String>(),
                    Phone = d["Phone"].Value<String>(),
                    Mail = d["Mail"].Value<String>()

                });
               return users;
        }
    }
}
