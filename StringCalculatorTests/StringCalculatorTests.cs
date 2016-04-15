// unit test code
using NUnit.Framework;
using FluentAssertions;
using StringCalculatorNS;

namespace StringCalculatorTests
{
    public class StringCalculatorTests
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3", 6)]
        [TestCase("1\n2,3", 6)]
        [TestCase("//;\n1;2", 3)]
        public void should_count_sum_of_numbers_in_string(string numbers, int expected)
        {
            // arrange
            var calc = new StringCalculator();

            // act
            var actual = calc.Add(numbers);

            // assert
            actual.Should().Be(expected);
        }
    }
}
