using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Triangle
    {
        //properties
        public int Mala1;
        public int Mala2;
        public int Mala3;
        //constructor
        public Triangle(int m1, int m2, int m3)
        {
            Mala1 = m1;
            Mala2 = m2;
            Mala3 = m3;
        }
        //methods
        public double Area()
        {
            double s = (Mala1 + Mala2 + Mala3) / 2;
            return Math.Sqrt(s * (s - Mala1) * (s - Mala2) * (s - Mala3));
        }

        public int Perimeter()
        {
            return Mala1 + Mala2 + Mala3;
        }
    }
}
