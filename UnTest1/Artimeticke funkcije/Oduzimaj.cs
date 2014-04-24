using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnTest1.Aplikacija;

namespace UnTest1.Artimeticke_funkcije
{
    class Oduzimaj : IzvorisnaKlasa
    {
        private int rez = 0;
        public Oduzimaj(int x, int y) : base(x, y)
        {
        }

        private void Oduzmi()
        {
            rez = base.n1 - base.n2;
            base.PostaviRezultat(rez);
        }

        public void Print()
        {
            Oduzmi();
            base.IspisiRezultat();
        }
     }
    
}
