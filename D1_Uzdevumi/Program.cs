using System;

namespace D1_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            //LietotajaVards(); izsauc funkciju
            //LietotajaVecums(); izsauc funkciju
            //Pilngadigs();
            Calc();
            Console.Read();
        }

        static void LietotajaVecums()
        {
            Console.Write("Ievadi Vecumu: ");
            int vecums = int.Parse(Console.ReadLine()); //parveido string to int, jo ReadLine darbojas tikai ar String
            vecums = vecums + 10;

            Console.WriteLine("Tavs vecums pec 10 gadiem bus {0}!", vecums);
        }
        static void LietotajaVards()
        {
            Console.Write("Ievadi Vaardu: ");
            string vards = Console.ReadLine();

            Console.Write("Ievadi Uzvaardu: ");
            string uzvards = Console.ReadLine();

            //Console.WriteLine("Tevi sauc " + vards + " " + uzvards + "!"); viens parametrs
            Console.WriteLine("Tevi sauc {0} {1}!", vards, uzvards); //tris parametri
        }

        static void Pilngadigs()
        {
            Console.Write("Ievadi savu vecumu: ");
            int vecums = int.Parse(Console.ReadLine()); //parveido string to int, jo ReadLine darbojas tikai ar String

            if (vecums < 18)
            {
                Console.WriteLine("Tu neesi pilngadigs!");
            }
            else if (vecums == 18)
            {
                Console.WriteLine("Tev ir tiesi 18!");
            }
            else
            {
                Console.WriteLine("Tu esi pilngadigs!");
            }
        }
        static void Calc()
        {
            Console.Write("Ievadi pirmo ciparu: ");
            int cipars1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi otro ciparu: ");
            int cipars2 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi velamo operaciju +, -, * vai /, ");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine("Rezultats ir {0}", cipars1 + cipars2); //var ari bez int
            }
            else if (operation == "-")
            {
                int rezultats = cipars1 - cipars2;
                Console.WriteLine("Rezultats ir " + rezultats);
            }
            else if (operation == "/")
            {
                
                if (cipars2 != 0)
                {
                    int rezultats = cipars1 / cipars2;
                    Console.WriteLine("Rezultats ir " + rezultats);
                }
                else
                {
                    Console.WriteLine("Nav atlauts dalit ar 0!");
                }
            }
            else if (operation == "*")
            {
                int rezultats = cipars1 - cipars2;
                Console.WriteLine("Rezultats ir " + rezultats);
            }
            else
            {
                Console.WriteLine("Darbiba nav atlauta!");
            }

            /*switch (operation)
            {
                case "+":
                    Console.WriteLine("Summa ir {0}", cipars1 + cipars2);
                    break;
                case "-":
                    Console.WriteLine("Summa ir {0}", cipars1 - cipars2); izmanto vertibu uzskaitei
                    break;
                case "*":
                    Console.WriteLine("Summa ir {0}", cipars1 * cipars2);
                    break;
                case "/":
                    Console.WriteLine("Summa ir {0}", cipars1 / cipars2);
                    break;
                default:
                    Console.WriteLine("Darbiba nav atlauta!");
                    break;
            }*/
        }
    }
}
