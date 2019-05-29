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
        public string getBalance;
        public string currency;
        public double totalSum;

        //constructor
        public Account()
        {
            totalSum = 0;
        }

        //methods
        public string GetBalance()
        {
            getBalance = totalSum.ToString();
            return getBalance;
        }
            public double Deposit(double summa)
        {
            totalSum += summa;
            return totalSum;
        }
        public void Withdraw(double summa)
        {
            if (totalSum >= summa)
            {
                totalSum -= summa;
            }
            else
            {
                Console.WriteLine("Konta nepietiek lidzeklu!");
            }
        }
    }
}
