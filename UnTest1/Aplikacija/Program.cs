using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnTest1.Aplikacija;
using UnTest1.Artimeticke_funkcije;

namespace UnTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            while(true)
            {

                Console.Write("Molim unesite odabir zeljene operacije [1-6]: ");
                var operacija = Convert.ToInt32(Console.ReadLine());

                Operacija op = null;
                switch (operacija)
                {
                    case 1:
                        op = new Zbrajanje();
                        break;
                    case 2:
                        op = new Oduzimanje();
                        break;
                    case 3:
                        op = new Mnozenje();
                        break;
                    case 4:
                        op = new Dijeljenje();
                        break;
                    case 5:
                        op = new Potenciranje();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Unijeli ste pogresan odabir, molim ponovite unos!");
                        Console.WriteLine();
                        break;
                }
                op.UcitajBrojeve();
                op.Perform();
                op.IspisiRezultat();
            };
        }

        private static void PrintHeader()
        {
            Console.WriteLine("Dobro dosli u kalkulator");
            Console.WriteLine("Molim odaberite neku od ponudjenih opcija");
            Console.WriteLine("==========================================");
            Console.WriteLine("\n1. Zbrajanje");
            Console.WriteLine("2. Oduzimanje");
            Console.WriteLine("3. Mnozenje");
            Console.WriteLine("4. Dijeljenje");
            Console.WriteLine("5  Potenciranje");
            Console.WriteLine("6. Kraj rada");
        }
    }
}
