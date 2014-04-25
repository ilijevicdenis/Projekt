using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnTest1.Aplikacija
{
    class Potenciranje : Operacija
    {
       
            public override void Perform()
            {
                rezultat = Math.Pow(n1, n2);
            }
 
    }
}
