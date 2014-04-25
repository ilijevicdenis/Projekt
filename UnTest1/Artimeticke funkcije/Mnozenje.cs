using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnTest1.Aplikacija;

namespace UnTest1.Artimeticke_funkcije
{
    class Mnozenje : Operacija
    {
        public override void Perform()
        {
            rezultat = n1 * n2;
        }
    }
}
