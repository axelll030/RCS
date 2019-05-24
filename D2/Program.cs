using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //Uzdevums1();
            //Uzdevums2();
            //Uzdevums3();
            //Uzdevums4();
            Uzdevums5();
            Console.Read();
        }

        static void Piemers()
        {
            for (int i = 1; i <= 100; i++) //i++ tas pats ka i = i + 1, ++i, i += 1. Var izmantot ari mainigo no lietotaja nevis 100
            {
                Console.WriteLine(i);
            }
        }

        static void Uzdevums1()
        {
            Console.Write("Ievadiet gadu: ");
            int gads = int.Parse(Console.ReadLine());

            /*for (int i = gads; i <= 2019; i++)
            {
                Console.WriteLine("{0}. gads", i);
            }*/

            for (; gads <= DateTime.Now.Year; gads++) // 2019 vieta var panemt DateTime.Now.Year
            {
                Console.WriteLine("{0}. gads", gads);
            }
        }
        static void Uzdevums2()
        {
            Console.Write("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());

            int summa = 0;
            for (int i = 1; i <= sk; i++)
            {
                if (i % 2 == 0) //izvadam tikai para skaitlus
                {
                    Console.WriteLine(i);
                    summa += i; // saskaitam visus izvaditos skaitlus i summaa 
                }
            }
            Console.WriteLine("Summa ir {0}!", summa);
        }
        static void Uzdevums3()
        {
            //array ar nosaukumu skaitli
            int[] skaitli = new int[5];
            skaitli[0] = 56;
            skaitli[1] = 32;
            skaitli[2] = 44;
            skaitli[3] = 1;
            skaitli[4] = 5; //piektais elements pozcija 4
            //skaitli[5] = 11; kluda, jo arpuss massiva

            //nolasisana
            int pirmaisSkaitlis = skaitli[0]; //nolasam skaitli no pozicijas 0

            for (int i = 0; i < skaitli.Length; i++) //skaitli.Lenght funkcija massiva lielumam
            {
                int skaitlis = skaitli[i];
                Console.WriteLine(skaitlis); // vai Console.WriteLine(skaitli[i]);
            }
        }
        static void Uzdevums4()
        {
            int[] skaitli = new int[5];

            for (int i = 0; i < skaitli.Length; i++)
            {
                Console.Write("Ievadi {0}. skaitli: ", i + 1);
                skaitli[i] = int.Parse(Console.ReadLine());
            }

            int min = skaitli.Min();    // mekle mazako massiva
            Console.WriteLine("Min = {0}", min);

            int max = skaitli.Max();    //mekle lielako massiva
            Console.WriteLine("Max = {0}", max);
        }

        static void Uzdevums5()
        //izvadit preteja seciba no ievaditaa
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Ievadi {0}. skaitli: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = array.Length - 1; i >= 0; i--) //ejam no otra gala
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
