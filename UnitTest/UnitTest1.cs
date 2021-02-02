using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = -1;
            double a = 1;
            double b = 2;
            double c = 2;
            double exp = 3;

            Unit.Unit F = new Unit.Unit();
            double act = F.calc(x, a, b, c);

            Assert.AreEqual(exp, act);
        }
    }
}
