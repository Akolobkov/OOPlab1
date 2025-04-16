
using System;
using System.Security.Principal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windows.Foundation.Numerics;
namespace RationalTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToString()
        {
            Rational rational1 = new Rational(1, 2);
            
            Assert.AreEqual(rational1.ToString(), $"1/2");
        }
        [TestMethod]
        public void Testinc()
        {
            Rational rational1 = new Rational(1, 2);
            Rational rational2 = new Rational(1, 2);
            Assert.AreEqual($"1", (rational1+rational2).ToString());
        }
        [TestMethod]
        public void Testdec()
        {
            Rational rational1 = new Rational(1, 2);
            Rational rational2 = new Rational(1, 4);
            Assert.AreEqual($"1/4", (rational1 - rational2).ToString());
        }
        [TestMethod]
        public void Testmult()
        {
            Rational rational1 = new Rational(1, 2);
            Rational rational2 = new Rational(1, 5);
            Assert.AreEqual($"1/10", (rational1 * rational2).ToString());
        }
        [TestMethod]
        public void Testdel()
        {
            Rational rational1 = new Rational(1, 5);
            Rational rational2 = new Rational(1, 5);
            Assert.AreEqual($"1", (rational1 / rational2).ToString());
        }
        [TestMethod]
        public void Testminus()
        {
            Rational rational1 = new Rational(1, 5);
            Assert.AreEqual($"-1/5", (-rational1).ToString());
        }
        [TestMethod]
        public void Testequal()
        {
            Rational rational1 = new Rational(1, 5);
            Rational rational2 = new Rational(2, 10);
            Assert.AreEqual(true, rational1 == rational2);
        }
        [TestMethod]
        public void Testunequal()
        {
            Rational rational1 = new Rational(1, 5);
            Rational rational2 = new Rational(3, 10);
            Assert.AreEqual(true, rational1 != rational2);
        }
        [TestMethod]
        public void Testmoreequal()
        {
            Rational rational1 = new Rational(2, 5);
            Rational rational2 = new Rational(3, 10);
            Assert.AreEqual(true, rational1 >= rational2);
        }
        public void Testlessequal()
        {
            Rational rational1 = new Rational(2, 5);
            Rational rational2 = new Rational(4, 10);
            Assert.AreEqual(true, rational1 <= rational2);
        }
    }
}
