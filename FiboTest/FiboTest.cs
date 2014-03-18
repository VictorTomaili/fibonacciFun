using System;
using System.Numerics;
using Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiboTest
{
    [TestClass]
    public class FiboTest
    {
        [TestMethod]
        public void Test50()
        {
            var result = Fibonacci.Calc(50);
            Assert.AreEqual(result.ToString(),"12586269025");
        }

        [TestMethod]
        public void Test100()
        {
            var result = Fibonacci.Calc(100);
            Assert.AreEqual(result.ToString(), "354224848179261915075");
        }

        [TestMethod]
        public void Test200()
        {
            var result = Fibonacci.Calc(200);
            Assert.AreEqual(result.ToString(), "280571172992510140037611932413038677189525");
        }

        [TestMethod]
        public void Test300()
        {
            var result = Fibonacci.Calc(300);
            Assert.AreEqual(result.ToString(), "222232244629420445529739893461909967206666939096499764990979600");
        }
        [TestMethod]
        public void Test1000()
        {
            var result = Fibonacci.Calc(1000);
            Assert.IsNotNull(result);
        }
    }
}
