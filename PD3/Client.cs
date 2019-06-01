using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Client
    {
        //properties
        public string vards;
        public string uzvards;
        public string dzimums;

        //constructor
        public Client(string v, string uz, string dz)
        {
            vards = v;
            uzvards = uz;
            dzimums = dz;
        }
    }
}
