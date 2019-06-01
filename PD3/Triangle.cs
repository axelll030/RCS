using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Triangle : IDaudzsturis
    {
        //properties
        public double Mala1;
        public double Mala2;
        public double Mala3;
        //constructor
        public Triangle(double m1, double m2, double m3)
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

        public double Perimeter()
        {
            return Mala1 + Mala2 + Mala3;
        }
    }
}
