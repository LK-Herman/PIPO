using System;
using Lab6_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SilniaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Silnia_0()
        {
            Silnia silnia = new Silnia();
            Assert.AreEqual(silnia.Oblicz(0), 1);
        }
        [TestMethod]
        public void Silnia_1()
        {
            Silnia silnia = new Silnia();
            Assert.AreEqual(silnia.Oblicz(1), 1);
        }
        [TestMethod]
        public void Silnia_5()
        {
            Silnia silnia = new Silnia();
            Assert.AreEqual(silnia.Oblicz(5), 120);
        }

    }
}
