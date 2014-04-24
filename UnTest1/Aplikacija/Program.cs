using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnTest1.Aplikacija;
using UnTest1.Artimeticke_funkcije;
using UnTest1.Potenciranje;

namespace UnTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, operacija;
            bool radi = true;
            UnosBrojeva unos = new UnosBrojeva();
            
            pocetak:
            Console.WriteLine("Dobro dosli u kalkulator");
            Console.WriteLine("Molim odaberite neku od ponudjenih opcija");
            Console.WriteLine("==========================================");
            
            do
            {
                Console.WriteLine("\n1. Zbrajanje");
                Console.WriteLine("2. Oduzimanje");
                Console.WriteLine("3. Mnozenje");
                Console.WriteLine("4. Dijeljenje");
                Console.WriteLine("5  Potenciranje");
                Console.WriteLine("6. Kraj rada");
                Console.Write("Molim unesite odabir zeljene operacije [1-6]: ");
                operacija = Convert.ToInt32(Console.ReadLine());

                if (operacija < 1 || operacija > 6)
                {
                    Console.WriteLine("Unesli ste pogresan odabir, molim ponovite unos!");
                    Console.WriteLine();
                }

                switch (operacija)
                {
                    case 1:
                        {
                            unos.UcitajBrojeve();
                            Zbrajaj zbr = new Zbrajaj(unos.get_a(), unos.get_b());
                            zbr.Print();
                            break;
                        }
                    case 2:
                        {
                            unos.UcitajBrojeve();
                            Oduzimaj oduzmi = new Oduzimaj(unos.get_a(), unos.get_b());
                            oduzmi.Print();
                            break;
                        }
                    case 3:
                        {
                            unos.UcitajBrojeve();
                            Mnozenje mnozi = new Mnozenje(unos.get_a(), unos.get_b());
                            mnozi.PrintData();
                            break;
                        }
                    case 4:
                        {
                            unos.UcitajBrojeve();
                            Dijeljenje dijeli = new Dijeljenje(unos.get_a(), unos.get_b());
                            dijeli.IspisiRezultat();
                            break;
                        }
                    case 5:
                        {
                            Potenciraj potencija = new Potenciraj();
                            potencija.GetData();
                            potencija.IspisiRezultat();
                            break;
                        }
                    case 6:
                        {
                            radi = false;
                            break;
                        }
                }
            } while ( (operacija < 1 || operacija > 7) || (radi == true) );
        }
    }
}
