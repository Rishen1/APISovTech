using Microsoft.AspNetCore.Mvc;
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
    public class StarWarsController : ControllerBase
    {
        private readonly IStarWars _StarWars;

        public StarWarsController(IStarWars starWars)
        {
            _StarWars = starWars;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("/swapi/people")]
        [SwaggerOperation(Summary = "List of starwars people", Description = "List of starwars people")]
        public ActionResult GetStarWarPeople()
        {

            return Ok(_StarWars.StarWarsPeople());

        }
       
        //[HttpGet("Search/{query}")]
     
        //[SwaggerOperation(Summary = "Search result of starwars people", Description = "Search result of starwars people")]
        //public ActionResult StarwarSearch(string query)
        //{

        //    return Ok(_StarWars.starwarSearch(query));

        //}
    }
}
