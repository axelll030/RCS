using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums1();
            //Uzdevums2();
            //Uzdevums3();
            //Uzdevums4();
            //Uzdevums5();
            Uzdevums6();
        }

        public static void Uzdevums1()
        {
            Console.Write("Ievadiet pirmo vardu: ");
            string v1 = Console.ReadLine().ToLower();//convert to all small letters. 

            Console.Write("Ievadiet otro vardu: ");
            string v2 = Console.ReadLine();

            Console.Write("Ievadiet treso vardu: ");
            string v3 = Console.ReadLine();

            Console.WriteLine("Jusu ievaditie vardi ir - {0}, {1}, {2}!", v1, v2, v3);
            Console.ReadLine();
        }

        public static void Uzdevums2()
        {
            Console.Write("Ludzu ievadiet jusu vecumu: ");
            int vecums = int.Parse(Console.ReadLine());

            if (vecums >= 50)
            {
                Console.WriteLine("Jusu ievaditajs vecums ({0}) parsniedz 50 gadus!", vecums);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Jusu ievaditajs vecums ({0}) neparsniedz 50 gadus!", vecums);
                Console.ReadLine();
            }
        }

        public static void Uzdevums3()
        {
            Console.Write("Ludzu ievadiet jebkuru vardu: ");
            string vards = Console.ReadLine();

            string lielvards = vards.ToUpper();

            Console.WriteLine(lielvards);
            //Console.WriteLine(vards.ToUpper()); lidzigs
            Console.ReadLine();
        }

        public static void Uzdevums4()
        {
            Console.Write("Ludzu ievadiet ciparu: ");
            int sk1 = int.Parse(Console.ReadLine());

            if (-50 <= sk1 && sk1 <= 50) // || && - un, || - vai
            {
                Console.Write("Cipars {0} atrodas intervala no -50 lidz 50 ieskaitot!", sk1);
                Console.ReadLine();
            }
            else
            {
                Console.Write("Cipars {0} atrodas arpus intervala no -50 lidz 50 ieskaitot!", sk1);
                Console.ReadLine();
            }
        }

        public static void Uzdevums5()
        {
            Console.Write("Ludzu ievadiet skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            if ((sk1 % 2) == 0) //panem atlikuma dalu (skaitls kas paliek pari)
                                /*
                                 * sk = 48205
                                 * sk % 10 = 5
                                 * sk / 10 = 40820
                                 * 482 % 10 = 0
                                 * 482 % 10 = 2
                                 */
            {
                Console.WriteLine("Skaitlis {0} ir para skaitlis!", sk1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Skaitlis {0} ir nepara skaitlis!", sk1);
                Console.ReadLine();
            }
        }

        public static void Uzdevums6()
        {
            //you can compare sk1 and sk2, and then sk3 to min or max(sk1 or sk2)
            Console.Write("Ludzu ievadiet pirmo skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Ludzu ievadiet otro skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            Console.Write("Ludzu ievadiet treso skaitli: ");
            int sk3 = int.Parse(Console.ReadLine());

            int lielakais;
            int mazakais;

            if ((sk1 > sk2) && (sk1 > sk3))
            {
                lielakais = sk1;
            }

            else if ((sk2 > sk1) && (sk2 > sk3))
            {
                lielakais = sk2;
            }

            else
            {
                lielakais = sk3;
            }

            if ((sk1 < sk2) && (sk1 < sk3))
            {
                mazakais = sk1;
            }

            else if ((sk2 < sk1) && (sk2 < sk3))
            {
                mazakais = sk2;
            }

            else
            {
                mazakais = sk3;
            }

            Console.WriteLine("No skaitliem {0}, {1} un {2}, skaitlis {3} ir lielakais un skaitlis {4} ir mazakais!", sk1, sk2, sk3, lielakais, mazakais);
            Console.ReadLine();
        }
        /* 
         * if(sk1 < sk2)
         * {
         * 
         * }
         * else
         * {
         * 
         * }
         * 
         * jeb
         * 
         * shorthand if
         * NOSACIJUMS ? IR PATIESS : NAV PATIESS
         * int min2 = sk1 < sk2 > ? sk1 : sk2;
         * min2 =sk3 < min2 ? sk3 : min2;
         * 
         * int max2 = sk1 > sk2 :? sk1 : sk2;
         * min2 = sk3 > max2 ? sk3 : max2;
         */

        /*
         * MinMax funkcija
         * int min3 = Math.Min(MathMin(sk1, sk2), sk3);
         * int max3 = MathMax(MathMax(sk1, sk2), sk3);
         */
    }
}
