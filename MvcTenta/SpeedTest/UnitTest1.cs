using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcTenta.Models;

namespace SpeedTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCorrectNumber()
        {
            var inputM = "4";
            var inputS = "2";
            var correctNumber = 2;
            Speed speed = new Speed();
            var actual = speed.GetCurrentSpeed(inputM, inputS);
            var expected = correctNumber;
            Assert.AreEqual(actual,expected);
        }
        [TestMethod]
        public void TestMethodWithDecimal()
        {
            var inputM = "4,1";
            var inputS = "2,1";
            var correctNumber = 1.9523809523809521;
            Speed speed = new Speed();
            var actual = speed.GetCurrentSpeed(inputM, inputS);
            var expected = correctNumber;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        
        public void TestMethodWithDot()
        {
            var inputM = "4.1";
            var inputS = "2.1";
            var correctNumber = 1.9523809523809521;
            Speed speed = new Speed();
            var actual = speed.GetCurrentSpeed(inputM, inputS);
            var expected = correctNumber;
            Assert.AreEqual(actual, expected);
        }
    }
}
