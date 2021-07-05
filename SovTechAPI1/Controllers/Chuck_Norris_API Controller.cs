using Microsoft.AspNetCore.Mvc;
using RestSharp;
using SovTechAPI1.Model;
using SovTechAPI1.Repo;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace SovTechAPI1.Controllers
{
    [ApiController]
    [System.Web.Http.Route("[controller]")]
    public class Chuck_Norris_API_Controller : ControllerBase
    {
        private readonly IChuck_Noris _chuck_Noris;

        public Chuck_Norris_API_Controller(IChuck_Noris chuck_)
        {
            _chuck_Noris= chuck_;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("/chuck/categories")]
        [SwaggerOperation(Summary = "List of Jokes", Description = "List of Jokes")]
        public ActionResult GetJokes()
        {
            
            return Ok(_chuck_Noris.JokeCategories());
 
        }

       
    }
}



