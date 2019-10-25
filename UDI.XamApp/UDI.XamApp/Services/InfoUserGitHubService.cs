using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UDI.XamApp.Models;

namespace UDI.XamApp.Services
{
    public class InfoUserGitHubService
    {
        const string UrlService = "https://api.github.com/users/";

        public async Task<GithubUser> GetUserInfoGithub(string name)
        {
            using (var client = new HttpClient())
            {
                // recursos 
                client.BaseAddress = new Uri(UrlService);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(
                        "application/json")
                    );
                var url = UrlService + name;
                HttpResponseMessage response = new HttpResponseMessage();
                try
                {
                    response = await client.GetAsync(url);
                }
                catch (Exception)
                {
                    // Logger
                    throw;
                }

                GithubUser lista = new GithubUser();
                if (response.IsSuccessStatusCode)
                {
                    // Convertimos el resultado en una cadena o string
                    var result = await response.Content.ReadAsStringAsync();
                    try
                    {
                        // Convertimos la cadena a objetos Json
                        var lis = JsonConvert.DeserializeObject<GithubUser>(result,
                                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                        lista = lis;
                    }
                    catch (Exception)
                    {
                        // Logger
                        throw;
                    }
                }
                return lista;
            };
        }
    }
}
