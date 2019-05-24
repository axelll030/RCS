using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers1();
            //Piemers2();
            Piemers3();
            Console.ReadLine();
        }

        static void Piemers1()
        {
            List<int> skaitli = new List<int>
            {
                5,
                78,
                -10
            };

            //for (int i = 0; i < skaitli.Count; i++)
            //{
            //    Console.WriteLine(skaitli[i]);
            //}

            int min = skaitli.Min();
            int max = skaitli.Max();

            skaitli.Add(1000);
            skaitli.Insert(1, 10000); //ievetot pirma pozicija
            skaitli.RemoveAt(2); //dzes konkreta pozicija

            foreach (int sk in skaitli)
            {
                Console.WriteLine(sk);
            }
        }

        static void Piemers2()
        {
            List<int> skaitli = new List<int>();
            //for (; ; ) cikls bez nosacijumiem
            //{
            //}
            while (true) 
            {
                Console.Write("Ievadiet skaitli (exit lai partrauktu): ");
                string ievade = Console.ReadLine();

                if (ievade == "exit")
                {
                    break; //partraukt ciklu
                }
                else
                {
                    int skaitlis = int.Parse(ievade);
                    skaitli.Add(skaitlis);
                }
            }

            int skaits = 0;

            foreach (int sk in skaitli)
            {
                if (sk == 10)
                {
                    skaits++;
                }
            }

            Console.WriteLine("Ievaditi {0} skaitli 10!", skaits);

            //int skaitlis = 10;
            //    while (skaitlis < 10)
            //    {
            //        skaitlis++;
            //    }
        }

        static void Piemers3()
        {
            //List<string> izveletasPreces = new List<string>
            //{
            //};

            List<int> grozs = new List<int>
            {
            };

            List<string> precesNosaukumi = new List<string>
            {
                "Dators",
                "Bikses",
                "Auto",
                "Mobilais",
                "TV",
                "Koferis",
                "Cimdi",
                "Cepure"
            };

            List<int> precesCenas = new List<int>
            {
                900,
                50,
                10000,
                200,
                550,
                100,
                20,
                10
            };

            int poz = 1;
            for (int i = 0; i < precesNosaukumi.Count; i++)
            {
                Console.WriteLine("{0}. {1} ${2}", poz, precesNosaukumi[i], precesCenas[i]);
                poz++;
            }
            //cikls vaicat ievadit preces numuru vai pabeight ieadi ar 0
            while (true)
            {
                Console.WriteLine();
                Console.Write("Ievadiet izveleto preces poziciju ('0' lai partrauktu): ");
                int ievade = int.Parse(Console.ReadLine());

                if (ievade == 0)
                {
                    break; //partraukt ciklu
                }
                else
                {
                    //izveletasPreces.Add(precesNosaukumi[ievade - 1]);
                    grozs.Add(precesCenas[ievade - 1]);
                }
            }

            Console.WriteLine();
            Console.Write("Kopeja summa apmaksai: ${0}", grozs.Sum());
        }
    }
}
