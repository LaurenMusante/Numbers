
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
    }
}