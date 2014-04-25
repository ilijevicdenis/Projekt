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
    class OduzimanjeTest
    {
        Operacija op;

        [SetUp]
        public void PostaviKlasu()
        {
            op = new Oduzimanje();
        }

        [Test]
        public void ZbrajanjeTest_OduzimaDvaBroja_VracaInt()
        {
            op.PostaviOperande(7, 2);
            op.Perform();
            Assert.AreEqual(5, op.rezultat);
        }
    }
}
