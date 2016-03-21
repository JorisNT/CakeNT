using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Tests
{
    [TestFixture]
    public class CalculatriceTests
    {
        [Test]
        public void AdditionTest()
        {
            Calculatrice c = new Calculatrice();
            Assert.AreEqual(5, c.Addition(8, 3));
        }
    }
}
