using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1;
            double a = 1;
            double b = 0;
            double c = -2;
            double exp = 0;

            Unit.Unit F = new Unit.Unit();
            double act = F.calc(x, a, b, c);

            Assert.AreEqual(exp, act);
        }
    }
}
