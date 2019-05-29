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

        public string PirktDzerienu()   //ari var izmantot void ja drikst neizvadit iemaksatu summu
        {
            if (IemaksataSumma >= 0.80)
            {
                //IemaksataSumma -= 0.80;
                //Console.WriteLine("Tava iemaksata summa {0}", IemaksataSumma);
                double atlikums = IemaksataSumma - 0.80;
                string atlikumsStr = atlikums.ToString();
                return atlikumsStr;
            }
            else
            {
                //Console.WriteLine("Nepietiek lidzeklu!");
                string nepietiekLidzeklu = "Jums nepietiek lidzeklu!";
                return nepietiekLidzeklu;
            }
        }

        public string SanemtAtlikumu()
        {
            //Console.WriteLine("Tu sanemi {0}", IemaksataSumma);
            //IemaksataSumma = 0;
            double atlikums = IemaksataSumma;
            IemaksataSumma = 0;
            string atlikumsStr = atlikums.ToString();
            return atlikumsStr;
        }
    }
}
