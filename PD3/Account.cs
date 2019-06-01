using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Account
    {
        //properties
        public string Currency;
        public Client Client;
        public decimal Summa;

        //constructor
        public Account(string currency)
        {
            Currency = currency;
            Summa = 0;
        }

        //methods

        public string GetBalance()
        {
            return String.Format("{0} {1}", Currency, Summa); //atgriezt ka ja butu writeline formata
        }

        public void Deposit(decimal summa)
        {
            if (summa > 10000)
            {
                Console.WriteLine("Viena reze nedrkst iemaksat vairak ka 10000EUR!");
            }
            else
            {
                Summa += summa;
                Console.WriteLine("Konta iemaksats {0}!", summa);
            }
        }

        public void Withdraw(decimal summa)
        {
            if (summa > Summa)
            {
                Console.WriteLine("Konta nepietiek lidzeklu!");
            }
            else if (summa > 500)
            {
                Console.WriteLine("Viena reze nedrkst nonemt vairak ka 500EUR!");
            }
            else
            {
                Summa -= summa;
                Console.WriteLine("No konta iznemts {0}!", summa);
            }
        }
    }
}
