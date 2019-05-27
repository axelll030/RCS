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
            Uzdevums3();
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

            //vareja ari:

            //sum = 0;
            //while (n != 0)
            //{
            //    sum += n % 10;
            //    n /= 10;
            //}
        }

        static void Uzdevums3()
        {
            List<int> skaitli = new List<int>();

            while (true)
            {
                Console.Write("Ievadiet skaitli ('stop' lai partrauktu): ");
                string ievade = Console.ReadLine();

                if (ievade == "stop")
                {
                    break; //partraukt ciklu
                }
                else
                {
                    int ievadeSk = int.Parse(ievade);
                    skaitli.Add(ievadeSk);
                }
            }

            // vai pareizi ??? skaitli.First() == skaitli.Last() ? "firstlast Skaitli {0} un {1} sakrit!", skaitli.First(), skaitli.Last() : "firstlast Skaitli {0} un {1} sakrit!", skaitli.First(), skaitli.Last()
            //ar iso if
            if (skaitli.First() == skaitli.Last())
            {
                Console.WriteLine("firstlast Skaitli {0} un {1} sakrit!", skaitli.First(), skaitli.Last());
            }
            else
            {
                Console.WriteLine("firstlast Skaitli {0} un {1} nesakrit!", skaitli.First(), skaitli.Last());
            }
        }
    }
}
