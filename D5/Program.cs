using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aprekini();
            Aplis();
            Console.Read();
        }
        static void Aprekini()
        {
            //taisnsturis -> klase
            //t1 -> objekts

            Taisnsturis t1 = new Taisnsturis();
            t1.Mala1 = 5;
            t1.Mala2 = 4;

            Taisnsturis t2 = new Taisnsturis(11, 11);

            Console.WriteLine("Laukums = {0}", t1.Laukums());
            Console.WriteLine("Perimetrs = {0}", t1.Perimeters());
            Console.WriteLine();
            Console.WriteLine("Laukums = {0}", t2.Laukums());
            Console.WriteLine("Perimetrs = {0}", t2.Perimeters());
        }

        static void Aplis()
        {
            Aplis a1 = new Aplis(15, "sarkans");
            Console.Write("Laukums ir {0} ", a1.Laukums());
            Console.Write(",krasa ir {0} ", a1.KrasasNosaukums());
            Console.Write("un perimetrs ir {0}!", a1.Perimetrs());

            Kvadrats k1 = new Kvadrats(5);
            k1.Perimeters();
            k1.Laukums();
        }
    }
}
