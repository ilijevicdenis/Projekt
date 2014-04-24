using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnTest1.Aplikacija;

namespace UnTest1.Artimeticke_funkcije
{
    class Dijeljenje:IzvorisnaKlasa
    {
        private int rezultat;

        public Dijeljenje(int a, int b)
            : base(a, b)
        {
        }

        private void Dijeli()
        {
            try 
                {
                    rezultat = base.n1 / base.n2;
                }
            catch (DivideByZeroException nula)
                {
                    rezultat = 0;
                }
        }

        public override void IspisiRezultat()
        {
            Dijeli();
            if ((rezultat == 0) && (base.n2 == 0))
            {
                throw new DivideByZeroException();
            }
            else
            {
                base.PostaviRezultat(rezultat);
                Console.WriteLine("Rezultat dijeljenja je: {0}", base.rezultat);
            }
        }
    }
}
