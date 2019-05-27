using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzerienuAutomats
{
    class DzerienuAutomats
    {
        //properties
        public double IemaksataSumma;

        //constr
        public DzerienuAutomats()
        {
            IemaksataSumma = 0;
        }

        //methods
        public double Iemaksat(double summa)
        {
            IemaksataSumma += summa;
            return IemaksataSumma;
        }

        public double PirktDzerienu()
        {
            if (IemaksataSumma >= 0.80)
            {
                double atlikums = IemaksataSumma - 0.80;
                return atlikums;
            }
            else
            {
                string nepietiekLidzeklu = "Jums nepietiek lidzeklu!";
                return nepietiekLidzeklu;
            }
        }

    }

}
