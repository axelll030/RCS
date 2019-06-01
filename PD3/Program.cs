using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aprekini();
            //Banka();
            Organizacija();
            
            Console.ReadLine();
        }

        //static void Aprekini()
        //{
        //    Square s1 = new Square(5);

        //    Console.WriteLine("Laukums = {0}", s1.Area());
        //    Console.WriteLine("Perimetrs = {0}", s1.Perimeter());
  
        //    Triangle t1 = new Triangle(5, 3, 4);

        //    Console.WriteLine("Laukums = {0}", s1.Area());
        //    Console.WriteLine("Perimetrs = {0}", t1.Perimeter());

        //    Pentagon p1 = new Pentagon(5);

        //    Console.WriteLine("Laukums = {0}", p1.Area());
        //    Console.WriteLine("Perimetrs = {0}", p1.Perimeter());
        //}
        static void Banka()
        {
            Account a = new Account("EUR");
            a.Client = new Client("Jānis", "Briedis", "V");
            Console.WriteLine("Atlikums: {0}", a.GetBalance());
            a.Deposit(150.0m);
            a.Withdraw(10.0m);
            Console.WriteLine("Atlikums: {0}", a.GetBalance());
        }

        static void Organizacija()
        {
            Organisation org = new Organisation("SIA mans uzņēmums");
            org.AddEmployee("Kaija", "Putniņa", "01/01/1980");
            org.AddEmployee("Dzidra", "Zupa", "25/05/1979");
            org.AddEmployee("Rūdolfs", "Briedis", "24/12/1983");
            org.Fire("Dzidra", "Zupa");
            org.ChangeData("Rūdolfs", "Briedis", "24/12/1973");
            org.PrintAllEmployees();
        }
    }
}
