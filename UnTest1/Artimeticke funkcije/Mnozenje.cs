using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnTest1.Aplikacija;

namespace UnTest1.Artimeticke_funkcije
{
    class Mnozenje : IzvorisnaKlasa
    {
        private int rezultat;

        public Mnozenje(int a, int b)
            : base(a, b)
        {
        }

        private int  Mnozi()
        {
            return base.n1 * base.n2;
        }

        public void PrintData()
        {
            rezultat = Mnozi();
            base.PostaviRezultat(rezultat);
            base.IspisiRezultat();
        }
    }
}
