// unit test code
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorNS;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void SumOfEmptyStringShouldBeZero()
        {
            // arrange
            int expected = 0;
            string numbers = "";
            StringCalculator calc = new StringCalculator();

            // act
            calc.Add(numbers);

            // assert
            int actual = calc.sum;
            Assert.AreEqual(expected, actual, "Sum of empty string is wrong");
        }

        [TestMethod]
        public void SumOfOneShouldBeOne()
        {
            // arrange
            int expected = 1;
            string numbers = "1";
            StringCalculator calc = new StringCalculator();

            // act
            calc.Add(numbers);

            // assert
            int actual = calc.sum;
            Assert.AreEqual(expected, actual, "Sum of '1' is wrong");
        }

        [TestMethod]
        public void SumOfOneAndTwoShouldBeThree()
        {
            // arrange
            int expected = 3;
            string numbers = "1,2";
            StringCalculator calc = new StringCalculator();

            // act
            calc.Add(numbers);

            // assert
            int actual = calc.sum;
            Assert.AreEqual(expected, actual, "Sum of '1,2' is wrong");
        }
    }
}
