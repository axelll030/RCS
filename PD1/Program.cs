using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1
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
            Console.Read();
        }

        static void Uzdevums1()
        {
            Console.Write("Ievadiet dalamo: ");
            int dal = int.Parse(Console.ReadLine());

            //Console.Write(dal % 3 == 0 
            //    ? "Dalas ar 3!" 
            //    : "Nedalas ar 3!");

            if (dal % 3 == 0)
            {
                Console.WriteLine("Dalisana ({0}) - ja!", dal);
            }
            else
            {
                Console.WriteLine("Dalisana ({0}) - ne!", dal);
            }
        }

        static void Uzdevums2()
        {
            Console.Write("Ievadiet skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Iznemot5 ({0}) ->", sk1);

            for (int i = 1; i <= sk1; i++)
            {
                if (i != 5)
                {
                    Console.Write(" " + i + ",");
                }
                //if (i == 5)
                //{
                //    continue;
                //}

                //Console.WriteLine(i);
            }
        }
        static void Uzdevums3()
        {
            Console.Write("Ievadiet darba dienu: ");
            string ddiena = Console.ReadLine().ToUpper();

            Console.Write("Vai jums ir atvainajums (J/N)?: ");
            string atv = Console.ReadLine().ToUpper();

            string laiksDarbaDienas;
            string laiksBrivDienas;

            if (atv == "J")
            {
                laiksDarbaDienas = "10:00";
                laiksBrivDienas = "OFF";
            }
            else
            {
                laiksDarbaDienas = "7:00";
                laiksBrivDienas = "10:00";
            }
            switch (ddiena)
            //case var sagrupet pa darba dienam un brivdienam:
            //case "P":
            //case "O":
            //case "T":
            //break;
            //un izmantot iso IF console.Write(value == "P" ? "OFF" : "10:00";)
            {
                case "P":
                case "O":
                case "T":
                case "C":
                case "PK":
                    Console.WriteLine("Modinatajs ('{0}', '{1}') -> '{2}'", ddiena, atv, laiksDarbaDienas);
                    break;

                case "SE":
                case "SV":
                    Console.WriteLine("Modinatajs ('{0}', '{1}') -> '{2}'", ddiena, atv, laiksBrivDienas);
                    break;

                default:
                    Console.WriteLine("Tadas dienas nav!");
                    break;
            }
        }
        static void Uzdevums4()
        {

            Console.Write("Ievadi sakuma skaitli: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Ievadi sakuma skaitli: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("FizzBuzz({0}, {1}): ", A, B);

            for (int i = A; i <= B; i++)
            {
                if ((i % 5 == 0) && (i % 3 == 0))
                {
                    Console.Write("FizzBuzz, ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz, ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }
        static void Uzdevums5()
        {
            Console.Write("Ievadiet skaitli: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("SkaitluSerija({0}) -> ", N);

            for (int i = 1; i <= N; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.Write(a + ", ");
                }
            }
        }
        static void Uzdevums6()
        { //array of words, pulling random element form array, spliting it to seperate array
            string[] vardiArray = { "SARKANS", "ZILS", "BRUNS", "MELNS" };
            Random rand = new Random();
            int index1 = rand.Next(vardiArray.Length);
            string wordToGuess = vardiArray[index1];
            char[] wordToGuessArray = wordToGuess.ToCharArray();
            bool riddleSolved = false;

            //Console.Write("CHECK: ");
            //for (int i = 0; i < wordToGuessArray.Length; i++)
            //{
            //    Console.Write(wordToGuessArray[i]);
            //}
            
            //creating empty array with "-", to fill in later on as user guesses letters
            int index2 = wordToGuessArray.Length;
            string[] emptyArrayToFill = new String[index2];
            for (int i = 0; i < emptyArrayToFill.Length; i++)
            {
                emptyArrayToFill[i] = "-";
            }

            //display word to guess with "-"
            Console.Write("Uzminiet vardu: ");
            for (int i = 0; i < emptyArrayToFill.Length; i++)
            {
                Console.Write(emptyArrayToFill[i] + " ");
            }

            //taisit ciklu, kamer...
            do
            {
                bool letterDoesExist = false;
                //user inputs a letter
                Console.Write(System.Environment.NewLine);
                Console.Write("Ievadiet burtu: ");
                string ievaditsBurts = Console.ReadLine().ToUpper();

                //comparing letter to array element
                //if they are equal, replace array[i] with lBurts
                for (int i = 0; i < wordToGuessArray.Length; i++)
                {
                    if (wordToGuessArray[i].ToString().Equals(ievaditsBurts))
                    {
                        emptyArrayToFill[i] = ievaditsBurts;
                        letterDoesExist = true;
                    }
                }
                if (!letterDoesExist)
                {
                    Console.Write(System.Environment.NewLine);
                    Console.Write("Burta {0} varda nav, meginiet velreiz!", ievaditsBurts);
                    Console.Write(System.Environment.NewLine);
                }
                //display updated wordToGuessArray
                Console.Write(System.Environment.NewLine);
                for (int i = 0; i < emptyArrayToFill.Length; i++)
                {
                    Console.Write("{0} ", emptyArrayToFill[i]);
                }
                //taisam rezultatu string no rezutlata array un parbaudam, vai varda ir palikusi "-"
                var emptyStringToFill = string.Join("", emptyArrayToFill);
                if (!emptyStringToFill.Contains("-"))
                {
                    Console.Write(System.Environment.NewLine);
                    Console.Write(System.Environment.NewLine);
                    Console.Write("Jus uzminejat vardu!");
                    riddleSolved = true;
                }
            }
            //...vards nebus pilnigi uzminets
            while (riddleSolved == false);
        }

    }
}