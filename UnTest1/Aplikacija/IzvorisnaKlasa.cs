using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnTest1.Aplikacija
{
    class IzvorisnaKlasa
    {
        protected int a;
        protected int b;
        protected int rezultat;

        public IzvorisnaKlasa(int x, int y)
        {
            n1 = x;
            n2 = y;
        }

        public int n1
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public int n2
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        protected virtual void PostaviRezultat(int z)
        {
            rezultat = z;
        }

        public virtual void IspisiRezultat()
        {
            Console.WriteLine("Rezultat je {0}", rezultat);
        }
    }
}
