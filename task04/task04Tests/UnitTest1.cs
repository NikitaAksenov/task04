using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using EpamTask04;

namespace EpamTask04Tests
{
    //[TestClass]
    public class UnitTest1
    {
        //[TestMethod]

        [TestCase("", 7)]
        [TestCase("_", 7)]
        [TestCase("+", 7)]
        [TestCase("-", 7)]
        [TestCase("++", 7)]
        [TestCase("--", 7)]
        [TestCase("12", 7)]
        [TestCase("12.5", 7)]
        [TestCase("-12", 7)]
        [TestCase("-12.5,13", 0.5)]
        [TestCase("12,13", 25)]
        [TestCase("-12.513", 0.5)]
        [TestCase("s1,13", 25.5)]
        [TestCase("12.5,13", 25.5)]
        [TestCase("12,34Ы", 25.5)]
        [TestCase("-1,1-", 25.5)]
        [TestCase(",", 25.5)]
        [TestCase("1,", 25.5)]
        [TestCase(", 1", 25.5)]
        [TestCase("1, -", 25.5)]
        [TestCase("_, 1", 25.5)]
        [TestCase("-3,+7", 4)]
        [TestCase("0,0", 0)]
        [TestCase("-0, +0", 0)]
        [TestCase("@@#", 25.5)]
        [TestCase("12.5,-13,+25.00,1E-1,0", 24.6)]
        [TestCase("12.5,-13+25.00,1E-1,0", 25.5)]

        public void Sum1Test(string str, double a)
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Sum1(str), a);
        }

        [TestCase("", 7)]
        [TestCase("_", 7)]
        [TestCase("+", 7)]
        [TestCase("-", 7)]
        [TestCase("++", 7)]
        [TestCase("--", 7)]
        [TestCase("12", 7)]
        [TestCase("12.5", 7)]
        [TestCase("-12", 7)]
        [TestCase("-12.5,13", 0.5)]
        [TestCase("12,13", 25)]
        [TestCase("-12.513", 0.5)]
        [TestCase("s1,13", 25.5)]
        [TestCase("12.5,13", 25.5)]
        [TestCase("12,34Ы", 25.5)]
        [TestCase("-1,1-", 25.5)]
        [TestCase(",", 25.5)]
        [TestCase("1,", 25.5)]
        [TestCase(", 1", 25.5)]
        [TestCase("1, -", 25.5)]
        [TestCase("_, 1", 25.5)]
        [TestCase("-3,+7", 4)]
        [TestCase("0,0", 0)]
        [TestCase("-0, +0", 0)]
        [TestCase("@@#", 25.5)]
        [TestCase("12.5,-13,+25.00,1E-1,0", 24.6)]
        [TestCase("12.5,-13+25.00,1E-1,0", 25.5)]

        public void Sum2Test(string str, double a)
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Sum2(str), a);
        }

        [TestCase("", 7)]
        [TestCase("_", 7)]
        [TestCase("+", 7)]
        [TestCase("-", 7)]
        [TestCase("++", 7)]
        [TestCase("--", 7)]
        [TestCase("12", 7)]
        [TestCase("12.5", 7)]
        [TestCase("-12", 7)]
        [TestCase("-12.5,13", 0.5)]
        [TestCase("12,13", 25)]
        [TestCase("-12.513", 0.5)]
        [TestCase("s1,13", 25.5)]
        [TestCase("12.5,13", 25.5)]
        [TestCase("12,34Ы", 25.5)]
        [TestCase("-1,1-", 25.5)]
        [TestCase(",", 25.5)]
        [TestCase("1,", 25.5)]
        [TestCase(", 1", 25.5)]
        [TestCase("1, -", 25.5)]
        [TestCase("_, 1", 25.5)]
        [TestCase("-3,+7", 4)]
        [TestCase("0,0", 0)]
        [TestCase("-0, +0", 0)]
        [TestCase("@@#", 25.5)]
        [TestCase("12.5,-13,+25.00,1E-1,0", 24.6)]
        [TestCase("12.5,-13+25.00,1E-1,0", 25.5)]

        public void Sum3Test(string str, double a)
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Sum3(str), a);
        }

        [TestCase("", 7)]
        [TestCase("_", 7)]
        [TestCase("+", 7)]
        [TestCase("-", 7)]
        [TestCase("++", 7)]
        [TestCase("--", 7)]
        [TestCase("12", 7)]
        [TestCase("12.5", 7)]
        [TestCase("-12", 7)]
        [TestCase("-12.5,13", 0.5)]
        [TestCase("12,13", 25)]
        [TestCase("-12.513", 0.5)]
        [TestCase("s1,13", 25.5)]
        [TestCase("12.5,13", 25.5)]
        [TestCase("12,34Ы", 25.5)]
        [TestCase("-1,1-", 25.5)]
        [TestCase(",", 25.5)]
        [TestCase("1,", 25.5)]
        [TestCase(", 1", 25.5)]
        [TestCase("1, -", 25.5)]
        [TestCase("_, 1", 25.5)]
        [TestCase("-3,+7", 4)]
        [TestCase("0,0", 0)]
        [TestCase("-0, +0", 0)]
        [TestCase("@@#", 25.5)]
        [TestCase("12.5,-13,+25.00,1E-1,0", 24.6)]
        [TestCase("12.5,-13+25.00,1E-1,0", 25.5)]

        public void Sum4Test(string str, double a)
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Sum4(str), a);
        }

        [TestCase("", 7)]
        [TestCase("_", 7)]
        [TestCase("+", 7)]
        [TestCase("-", 7)]
        [TestCase("++", 7)]
        [TestCase("--", 7)]
        [TestCase("12", 7)]
        [TestCase("12.5", 7)]
        [TestCase("-12", 7)]
        [TestCase("-12.5,13", 0.5)]
        [TestCase("12,13", 25)]
        [TestCase("-12.513", 0.5)]
        [TestCase("s1,13", 25.5)]
        [TestCase("12.5,13", 25.5)]
        [TestCase("12,34Ы", 25.5)]
        [TestCase("-1,1-", 25.5)]
        [TestCase(",", 25.5)]
        [TestCase("1,", 25.5)]
        [TestCase(", 1", 25.5)]
        [TestCase("1, -", 25.5)]
        [TestCase("_, 1", 25.5)]
        [TestCase("-3,+7", 4)]
        [TestCase("0,0", 0)]
        [TestCase("-0, +0", 0)]
        [TestCase("@@#", 25.5)]
        [TestCase("12.5,-13,+25.00,1E-1,0", 24.6)]
        [TestCase("12.5,-13+25.00,1E-1,0", 25.5)]

        public void Sum5Test(string str, double a)
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Sum5(str), a);
        }
    }
}
