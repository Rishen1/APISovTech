using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SovTechAPI1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SovTechAPI1.Repo
{
    public class Chuc_Noris_Repo : IChuck_Noris
    {
        private static RestClient client = new
       RestClient("https://api.chucknorris.io");

        public List<string> JokeCategories()
        {
            var client = new RestClient("https://api.chucknorris.io");
            var request = new RestRequest("/jokes/categories", Method.GET);
            var queryResult = client.Execute<List<string>>(request).Data;
            return queryResult;

        }

        public Joke JokesSearch(string query)
        {
            //https://api.chucknorris.io/jokes/random?category=money
            var client = new RestClient("https://api.chucknorris.io/");
            var request = new RestRequest($"jokes/random?category={query}", Method.GET);
            var queryResult = client.Execute(request).Content;
            
            var categoryList  = JsonConvert.DeserializeObject<Joke>(queryResult);
            categoryList.API = "ChuckNorris";
            return categoryList;
        }
    }
}



