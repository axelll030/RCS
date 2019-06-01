using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Square : IDaudzsturis
    {
        //properties
        public double Mala;
        //constructor
        public Square(double m1)
        {
            Mala = m1;
        }
        //methods
        public double Area()
        {
            return Mala * Mala;
        }

        public double Perimeter()
        {
            return Mala * 4;
        }
    }
}
