using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralConverterTests
{
    [TestClass]
    public class RomanNumeralTests
    {

        [TestMethod]
        public void ConvertI()
        {
            Assert.AreEqual(1, RomanNumeralConverter.Convert("I"));
        }

        [TestMethod]
        public void ConvertV()
        {
            Assert.AreEqual(5, RomanNumeralConverter.Convert("V"));
        }

        [TestMethod]
        public void ConvertX()
        {
            Assert.AreEqual(10, RomanNumeralConverter.Convert("X"));
        }

        [TestMethod]
        public void ConvertL()
        {
            Assert.AreEqual(50, RomanNumeralConverter.Convert("L"));
        }

        public void ConvertC()
        {
            Assert.AreEqual(100, RomanNumeralConverter.Convert("C"));
        }

        [TestMethod]
        public void ConvertD()
        {
            Assert.AreEqual(500, RomanNumeralConverter.Convert("D"));
        }

        [TestMethod]
        public void ConvertM()
        {
            Assert.AreEqual(1000, RomanNumeralConverter.Convert("M"));
        }

        [TestMethod]
        public void ConvertXI()
        {
            Assert.AreEqual(11, RomanNumeralConverter.Convert("XI"));
        }

    }
}
