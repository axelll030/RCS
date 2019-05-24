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
            //SkaitlaMinesana();
            Diamond();
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
            int[] numberArray = { 1, };
            //int numberToGuess = new Random().Next(1, 1000+1) - lai tukstotis ieskaitotu
            Random rand = new Random();
            int index1 = rand.Next(numberArray.Length);
            int numberToGuess = numberArray[index1];
  
            int meginajumi = 0;
            while (meginajumi < 5)
            {
                Console.Write("Miniet skaitli: ");
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber == numberToGuess)
                {
                    Console.Write(System.Environment.NewLine);
                    Console.Write("Pareizi!");
                    break;
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
                    Console.Write(System.Environment.NewLine);
                }
                meginajumi++;
            }
            if (meginajumi == 5)
            {
                Console.WriteLine("Jums beidzas meginajumi!");
            }    
        }

        static void Diamond()
        {
            Console.Write("Ievadiet skaitli: ");
            int rinduSkaits = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rinduSkaits; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
