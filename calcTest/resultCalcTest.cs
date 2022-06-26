using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculate;

namespace calcTest
{
    [TestClass]
    public class resultCalcTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            fCalc calc = new fCalc();
            double a = 5; double b = 10;
            double expected = a + b;
            double result;
            result = calc._bRavno_Click(a, b, 1);
            Assert.AreEqual(expected, result);
        }
    }
}
