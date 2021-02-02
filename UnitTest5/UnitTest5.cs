using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest5
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 3;
            double a = 0.5;
            double b = 1;
            double c = 1;
            double exp = 3;

            Unit.Unit F = new Unit.Unit();
            double act = F.calc(x, a, b, c);

            Assert.AreEqual(exp, act);
        }
    }
}
