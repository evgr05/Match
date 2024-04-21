using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using Match;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaWithRadius1()
        {
            Assert.AreEqual(3.14159, Circle.CalculateArea(1), 0.00001);
        }
        [TestMethod]
        public void AreaWithRadius0()
        {
            Assert.AreEqual(0, Circle.CalculateArea(0));
        }
        [TestMethod]
        public void AreaWithNegativeRadius()
        {
            Assert.ThrowsException<System.ArgumentException>(() => Circle.CalculateArea(-1));
        }
    }
}
