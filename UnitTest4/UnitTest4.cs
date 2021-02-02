using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest4
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = -1;
            double a = 0.5;
            double b = 0.5;
            double c = 2;
            double exp = 1;

            Unit.Unit F = new Unit.Unit();
            double act = F.calc(x, a, b, c);

            Assert.AreEqual(exp, act);
        }
    }
}
