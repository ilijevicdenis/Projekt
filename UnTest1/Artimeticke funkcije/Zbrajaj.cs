using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnTest1.Aplikacija
{
    class Zbrajaj : IzvorisnaKlasa
    {
        protected int Rez;
        public Zbrajaj(int x, int y) : base(x, y)
        {
        }

        private void Zbroji()
        {
            Rez = base.n1 + base.n2;
            base.PostaviRezultat(Rez);
        }

        public void Print()
        {
            Zbroji();
            base.IspisiRezultat();
        }
     }
 }

