using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.ADT
{
    internal class Pokemon
    {
        string name { get; set; }
        string type { get; set; }
        int exp {  get; set; }

        public bool IsPokemon()
        {
            return true;
        }
    }
}
