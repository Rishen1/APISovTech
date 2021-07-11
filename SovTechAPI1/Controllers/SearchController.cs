using Microsoft.AspNetCore.Mvc;
using SovTechAPI1.Model;
using SovTechAPI1.Repo;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovTechAPI1.Controllers
{
    [ApiController]
    [System.Web.Http.Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly IChuck_Noris _chuck_Noris;
        private readonly IStarWars _starwars;

        public SearchController(IChuck_Noris chuck_, IStarWars starWars)
        {
            _chuck_Noris = chuck_;
            _starwars = starWars;
        }
        /// <summary>
        /// Searches on jokes or starwars people it depends on the input parameter 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [Microsoft.AspNetCore.Mvc.HttpGet("Search/{query}")]
        [SwaggerOperation(Summary = "Returns back search request", Description = "Returns back search request")]
        public ActionResult GetJokeSearch(string query)
        {
            SearchResult sr = new SearchResult();
            Joke jokesList = new Joke();
            PeopleList peopleList = new PeopleList();
            jokesList = _chuck_Noris.JokesSearch(query);
            peopleList = _starwars.starwarSearch(query);
            if (jokesList.id != null)
            {
                return (Ok(jokesList));
            }
            else if (peopleList.count > 0)
            {

                return Ok(peopleList);
            }
            return Ok(null);
        }
    }
}

