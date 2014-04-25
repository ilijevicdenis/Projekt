using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using UnTest1.Aplikacija;

namespace UnTest1.Testovi.Aritmetika
{
    [TestFixture]
    public class ZbrajanjeTest
    {
        Operacija op;

        [SetUp]
        public void PostaviKlasu()
        {
            op = new Zbrajanje();
        }

        [Test]
        public void ZbrajanjeTest_zbrajaDvaBroja_VracaInt()
        {
            op.PostaviOperande(3, 2);
            op.Perform();
            Assert.AreEqual(5, op.rezultat);
        }
    }
}
