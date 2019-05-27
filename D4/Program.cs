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
            int N = int.Parse(Console.ReadLine());

            /*
               *    r=1, a=2=N-r, z=1=2*r-1
              ***   r=2, a=1, z=3
             *****  r=3, a=0, z=5
              ***   r=2, 
               *    r=1,
             */

            for (int r = 1; r <= N; r++)
            {
                for (int a = 1; a <= N-r; a++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= 2*r-1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int r = N - 1; r >= 1; r--)
            {
                for (int a = 1; a <= N - r; a++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= 2 * r - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
