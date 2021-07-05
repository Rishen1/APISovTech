using Newtonsoft.Json;
using RestSharp;
using SovTechAPI1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovTechAPI1.Repo
{
    public class StarwarsRepo : IStarWars
    {
        public PeopleList starwarSearch(string query)
        {
            var client = new RestClient("https://swapi.dev/api");
            var request = new RestRequest($"/people/?search={query}", Method.GET);
            var queryResult = client.Execute(request).Content;
            var peopleList = JsonConvert.DeserializeObject<PeopleList>(queryResult);
            peopleList.API = "StarWars";
            return peopleList;
        }

        public List<string> StarWarsPeople()
        {
            var client = new RestClient("https://swapi.dev/api");
            var request = new RestRequest("/people/", Method.GET);
            var queryResult = client.Execute<List<string>>(request).Data;
            return queryResult;
        }
    }
}
