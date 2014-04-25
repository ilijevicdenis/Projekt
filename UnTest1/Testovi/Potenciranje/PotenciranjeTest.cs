using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using UnTest1.Aplikacija;
using UnTest1.Artimeticke_funkcije;

namespace UnTest1
{
    class PotenciranjeTest
    {
        Operacija op = null;

        [SetUp]
        public void PostaviKlasu()
        {
            op = new Potenciranje();
        }

        [Test]
        public void PotenciranjeTest_PotenciraBazuNaEksponent_VracaBroj()
        {
            op.PostaviOperande(5, 3);
            op.Perform();
            Assert.AreEqual(125, op.rezultat);
        }

        [Test]
        public void PotenciranjeTest_PotenciraBazuNaEksponent_VracaKriviRezultat()
        {
            op.PostaviOperande(5, 3);
            op.Perform();
            Assert.AreNotEqual(220, op.rezultat);
        }
    }
}
