using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums1();
            //Uzdevums2();
            SkaitlaMinesana();
            Console.ReadLine();
        }

        static void Uzdevums1()
        {
            Console.Write("Ievadiet skaitli: ");
            int N = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= N; rinda++)
            {
                for (int kolona = 1; kolona <= N; kolona++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }

        static void Uzdevums2()
        {
            Console.Write("Ievadiet skaitli: ");
            int N = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= N; rinda++)
            {
                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);
                }
                Console.WriteLine();
            }
        }

        static void SkaitlaMinesana()
        {
            int[] numberArray = { 1, 15, 89, 46, 22, 99, 7, 66 };
            //int numberToGuess = new Random().Next(1, 1000+1) - lai tukstotis ieskaitotu
            Random rand = new Random();
            int index1 = rand.Next(numberArray.Length);
            int numberToGuess = numberArray[index1];
            bool riddleSolved = false;

            do
            {
                int meginajumi = 0;
                while (true)
                {
                    Console.Write("Miniet skaitli: ");
                    int inputNumber = int.Parse(Console.ReadLine());
                    if (inputNumber == numberToGuess)
                    {
                        Console.Write(System.Environment.NewLine);
                        Console.Write("Pareizi!");
                        riddleSolved = true;
                    }
                    else if (inputNumber > numberToGuess)
                    {
                        Console.WriteLine("Jusu ievadijat parak lielo skaitli!");
                        Console.Write(System.Environment.NewLine);
                    }
                    else if (inputNumber < numberToGuess)
                    {
                        Console.WriteLine("Jusu ievadijat parak mazu skaitli!");
                        Console.Write(System.Environment.NewLine);
                    }
                    
                    meginajumi++;
                    if (meginajumi >= 2)
                    {
                        Console.WriteLine("Jums beidzas meginajumi!");
                        break;
                    }
                }
            }
            while (!riddleSolved);
        }
    }
}
