
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Converter;

namespace Converter.Test
{
    [TestClass]
    public class NumberConverterTest
    {
        NumberConverter testNumberConverter = new NumberConverter();

        [TestMethod]
        public void ConvertToWords_NumbersOnly_TryAgain()
        {
            Assert.AreEqual("Numerical input only! Please try again.", testNumberConverter.ConvertToWords("ten"));
        }

        [TestMethod]
        public void ConvertToWords_ConvertSingleDigit_five()
        {
            Assert.AreEqual("five", testNumberConverter.ConvertToWords("5"));
        }
        [TestMethod]
        public void ConvertToWords_ConvertDoubleDigit_twentytwo()
        {
        Assert.AreEqual("twentytwo", testNumberConverter.ConvertToWords("22"));
        }
    }
}