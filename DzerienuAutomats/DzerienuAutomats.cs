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

        //constructor
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

        public string PirktDzerienu()
        {
            if (IemaksataSumma >= 0.80)
            {
                double atlikums = IemaksataSumma - 0.80;
                string atlikumsStr = atlikums.ToString();
                return atlikumsStr;
            }
            else
            {
                string nepietiekLidzeklu = "Jums nepietiek lidzeklu!";
                return nepietiekLidzeklu;
            }
        }

        public string SanemtAtlikumu()
        {
            double atlikums = IemaksataSumma - 0.80;
            IemaksataSumma = 0;
            string atlikumsStr = atlikums.ToString();
            return atlikumsStr;
        }
    }
}
