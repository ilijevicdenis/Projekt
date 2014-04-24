using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnTest1.Aplikacija
{
    class UnosBrojeva
    {
        private int a;
        private int b;

        public void UcitajBrojeve()
        {
            Console.Write("Unesite prvi broj: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public int get_a()
        {
            return a;
        }

        public int get_b()
        {
            return b;
        }
    }
}
