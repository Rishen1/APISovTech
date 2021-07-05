using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovTechAPI1.Model
{
    public class PeopleList
    {
        public List<People> results { get; set; }
        public int count { get; set; }

        public string API { get; set; }
    }
}
