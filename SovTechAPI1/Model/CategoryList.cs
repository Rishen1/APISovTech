using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovTechAPI1.Model
{
    public class CategoryList
    {
        public List<Joke> result { get; set; }
        public int total { get; set; }

        public string API { get; set; }
    }
}
