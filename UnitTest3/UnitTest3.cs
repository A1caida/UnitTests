using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1;
            double a = 1;
            double b = 1;
            double c = 2;
            double exp = 0.5;

            Unit.Unit F = new Unit.Unit();
            double act = F.calc(x, a, b, c);

            Assert.AreEqual(exp, act);
        }
    }
}
