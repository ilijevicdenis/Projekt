using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnTest1.Aplikacija;

namespace UnTest1.Faktorijel
{
    class Faktorijel
    {
        private int faktor;
        private int faktorijela = 1;

        public void Unos()
        {
            do {
                   Console.WriteLine("Unesite broj za kojeg zelite faktorijel [1-10]: ");
                   faktor = Convert.ToInt32(Console.ReadLine());
                    if (faktor < 0 || faktor > 10)
                    {
                        Console.WriteLine("Faktor van dopustene granice, molim pokusajte ponovno");
                        Console.Clear();
                    }
            } while (faktor < 0 || faktor > 10);
        }

        private void Faktorijela()
        {
            for (int i = faktor; faktor >= 1; faktor--)
            {
                faktorijela *= faktor;
            }
        }

        public void IspisiFaktorijel()
        {
            Console.WriteLine("Faktorijel za broj {0} iznosi {1}", faktor, faktorijela);
        }

    }
}
