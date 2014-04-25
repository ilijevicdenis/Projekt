using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnTest1.Aplikacija
{
    abstract class Operacija
    {
        public double n1 { get; protected set; }
        public double n2 { get; protected set; }
        public double rezultat { get; protected set; }
        public abstract void Perform ();

        public virtual void IspisiRezultat()
        {
            Console.WriteLine("Rezultat je {0}", rezultat);
        }

        public void UcitajBrojeve()
        {
            Console.Write("Unesite prvi broj: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            n2 = Convert.ToDouble(Console.ReadLine());
        }

        public void PostaviOperande(double a, double b)
        {
            n1 = a;
            n2 = b;
        }
    }
}

