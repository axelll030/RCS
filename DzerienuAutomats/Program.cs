using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzerienuAutomats
{
    class Program
    {
        static void Main(string[] args)
        {
            DzerienuAutomats();
            Console.ReadLine();
        }

        static void DzerienuAutomats()
        {
            DzerienuAutomats dzAu = new DzerienuAutomats();

            string[] menuArray = { "Iemaksat", "Pirkt Dzerienu", "Sanemt Atlikumu" };
            Console.WriteLine("VENDING MACHINE");
            Console.Write(Environment.NewLine);
            for (int i = 0; i < menuArray.Length; i++)
            {
                Console.WriteLine(menuArray[i]);
            }
            Console.WriteLine();

            while (true)
            {
                Console.Write("Ievadiet izveli: ");
                string ievade = Console.ReadLine().ToLower();
                if (ievade == "stop")
                    break;

                switch (ievade)
                {
                    case "iemaksat":
                        Console.Write("Ievadiet iemaksas summu: ");
                        double iemaksa = double.Parse(Console.ReadLine());
                        dzAu.Iemaksat(iemaksa);
                        Console.Write("Jusu iemaksata nauda: {0}", iemaksa);
                        Console.ReadLine();
                        break;

                    case "pirkt dzerienu":
                        Console.WriteLine(dzAu.PirktDzerienu());
                        Console.ReadLine();
                        break;

                    case "sanemt atlikumu":
                        Console.WriteLine("Jusu sanemtais atlikums ir: {0}", dzAu.SanemtAtlikumu());
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Nepareizi ievadita izvele! Meginiet velreiz.");
                        break;
                }
            }
        }   
    }
}
