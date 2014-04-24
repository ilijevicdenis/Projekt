using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnTest1.Aplikacija;

namespace UnTest1.Potenciranje
{
    class Potenciraj
    {
        UnosBrojeva unos1 = new UnosBrojeva();
        public void GetData()
        {
            unos1.UcitajBrojeve();
        }

        public void IspisiRezultat()
        {
            Console.WriteLine("Rezultat potenciranja je {0}", Math.Pow(unos1.get_a(), unos1.get_b()));
        }

    }
}
