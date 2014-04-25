using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using UnTest1.Aplikacija;
using UnTest1.Artimeticke_funkcije;


namespace UnTest1.Testovi.Aritmetika
{
    class MnozenjeTest
    {
        Operacija op = null;

        [SetUp]
        public void PostaviKlasu()
        {
            op = new Mnozenje();
        }

        [Test]
        public void MnozenjeTest_MnoziDvaBroja_VracaBroj()
        {
            op.PostaviOperande(7, 2);
            op.Perform();
            Assert.AreEqual(14, op.rezultat);
        }

    }
}
