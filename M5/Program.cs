using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums1();
            //Uzdevums2();
            //Uzdevums3();
            Uzdevums4Diamond();
            Console.ReadLine();
        }

        static void Uzdevums1()
        {
            List<int> skaitli = new List<int>();

            while (true)
            {
                Console.Write("Ievadiet skaitli ('13' lai partrauktu): ");
                int ievade = int.Parse(Console.ReadLine());

                if (ievade == 13)
                {
                    break; //partraukt ciklu
                }
                else
                {
                    skaitli.Add(ievade);
                }
            }

            Console.Write("stop13 ( ");

            for (int i = 0; i < skaitli.Count; i++)
            {
                Console.Write(skaitli[i] + ", ");
            }
            Console.Write(")-> {0}", skaitli.Sum());
        }

        static void Uzdevums2()
        {
            int summa = 0;
            Console.Write("Ievadiet skaitli: ");
            string skaitlis = Console.ReadLine();

            foreach (char sk in skaitlis)
            {
                summa += int.Parse(sk.ToString());
            }

            Console.WriteLine("sum{0} -> {1}", skaitlis, summa);
        }

        static void Uzdevums3()
        {
            List<int> skaitli = new List<int>();

            while (true)
            {
                Console.Write("Ievadiet skaitli ('0101' lai partrauktu): ");
                int ievade = int.Parse(Console.ReadLine());

                if (ievade == 0101)
                {
                    break; //partraukt ciklu
                }
                else
                {
                    skaitli.Add(ievade);
                }
            }
            if (skaitli.First() == skaitli.Last())
            {
                Console.WriteLine("firstast Skailti {0} un {1} sakrit!", skaitli.First(), skaitli.Last());
            }
            else
            {
                Console.WriteLine("firstast Skailti {0} un {1} nesakrit!", skaitli.First(), skaitli.Last());
            }
        }

        static void Uzdevums4Diamond()
        {

        }
    }
}
