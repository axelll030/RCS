using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD4
{
    class NumberGenerator
    {
        public double numberToGuess;
        public double inputNumber;

        public NumberGenerator()
        {
            Random rand = new Random();
            numberToGuess = rand.Next(1, 1001);
        }
        //Random rand = new Random();
        //numberToGuess = rand.Next(1, 1001);
    }
}
