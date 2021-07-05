using SovTechAPI1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovTechAPI1.Repo
{
    public interface IStarWars
    {
        List<string> StarWarsPeople();
        PeopleList starwarSearch(string query);
    }
}
