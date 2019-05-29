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
            Banka();
            Console.ReadLine();
        }

        static void Aprekini()
        {
            Square s1 = new Square(5);

            Console.WriteLine("Laukums = {0}", s1.Area());
            Console.WriteLine("Perimetrs = {0}", s1.Perimeter());
  
            Triangle t1 = new Triangle(5, 3, 4);

            Console.WriteLine("Laukums = {0}", s1.Area());
            Console.WriteLine("Perimetrs = {0}", t1.Perimeter());

            Pentagon p1 = new Pentagon(5);

            Console.WriteLine("Laukums = {0}", p1.Area());
            Console.WriteLine("Perimetrs = {0}", p1.Perimeter());
        }
        static void Banka()
        {
            Client cl = new Client("Imants", "Ziedonis", "V");
            Account a1 = new Account();

            Console.WriteLine("Atlikums: {0}", a1.getBalance);
        }
    }
}
