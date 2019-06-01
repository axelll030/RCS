using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Pentagon :IDaudzsturis
    {
        //properties
        public double Mala;
        //constructor
        public Pentagon(double m1)
        {
            Mala = m1;
        }
        //methods
        public double Area()
        {
            double malasPuse = 0.5 * Mala;
            int angle = 36;
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double augstums = malasPuse / tan;
            double smallA = 0.5 * malasPuse * augstums;
            double A = smallA * 10;
            return A;
        }

        public double Perimeter()
        {
            return Mala * 5;
        }
    }
}
