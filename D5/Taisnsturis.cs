using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Taisnsturis
    {
        //properties
        public int Mala1; //private tikai no Taisnstura klases

        public int Mala2; //protected tikai inherited klases

        //constructor, vards sakrit ar klases nosaukumu
        public Taisnsturis()
        {

        }
        public Taisnsturis(int m1, int m2)
        {
            Mala1 = m1;
            Mala2 = m2;
        }

        //methods
        public int Laukums()
        {
            return Mala1 * Mala2;
        }

        public int Perimeters()
        {
            return (Mala1 + Mala2) * 2;
        }
    }
}
