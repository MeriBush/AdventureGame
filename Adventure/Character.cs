using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    abstract class Character
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public bool HasEnergy { get; set; }
    }
}
