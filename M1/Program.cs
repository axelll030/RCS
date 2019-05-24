using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums1();
            //Uzdevums2();
            //Uzdevums3();
            Uzdevums4();
        }

        public static void Uzdevums1()
        {
            Console.Write("Ievadiet pirmo skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet otro skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            if (sk2 != 0)
            {
                int summa = sk1 + sk2;
                Console.WriteLine("Skaitlu summa ir " + summa);

                int starpiba = sk1 - sk2;
                Console.WriteLine("Skaitlu starpiba ir " + starpiba);

                int reizinajums = sk1 * sk2;
                Console.WriteLine("Skaitlu reizinajums ir " + reizinajums);

                float dalijums = (float)sk1 / sk2; //float to divide first number 
                Console.WriteLine("Skaitlu dalijums ir " + dalijums);
            }
            else
            {
                Console.WriteLine("Nevar dalit ar 0!");
            }
        }

        public static void Uzdevums2()
        {
            Console.Write("Ievadiet pirmo skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet otro skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet treso skaitli: ");
            int sk3 = int.Parse(Console.ReadLine());

            int reizinajums = sk1 * sk2 * sk3;
            Console.WriteLine("Skaitlu reizinajums ir " + reizinajums);
        }

        public static void Uzdevums3()
        {
            Console.Write("Ievadiet pirmo skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet otro skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            if (sk1 != sk2)
            {
                Console.Write("Skaitli {0} un {1} nav vienadi!", sk1, sk2);
            }
            else
            {
                Console.Write("Skaitli {0} un {1} ir vienadi!", sk1, sk2);
            }
        }
        public static void Uzdevums4()
        {
            Console.Write("Ievadiet valsti: ");
            string country = Console.ReadLine();

            switch (country)
            {
                case "Latvia":
                    Console.WriteLine("{0} --> Riga.", country);
                    Console.ReadLine();
                    break;

                case "Igaunija":
                    Console.WriteLine("{0} --> Tallina.", country);
                    Console.ReadLine();
                    break;

                case "Lietuva":
                    Console.WriteLine("{0} --> Vilna.", country);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Tadas valsts es nezinu!");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
