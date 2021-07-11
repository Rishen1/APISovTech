using RestSharp;
using SovTechAPI1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovTechAPI1.Repo
{
    public interface IChuck_Noris
    {
       List<string>  JokeCategories();
       Joke JokesSearch(string query);
              
    }
}
