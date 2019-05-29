using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Square
    {
        //properties
        public int Mala;
        //constructor
        public Square(int m1)
        {
            Mala = m1;
        }
        //methods
        public int Area()
        {
            return Mala * Mala;
        }

        public int Perimeter()
        {
            return Mala * 4;
        }
    }
}
