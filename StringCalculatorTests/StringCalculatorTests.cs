// unit test code
using NUnit.Framework;
using FluentAssertions;
using StringCalculatorNS;

namespace StringCalculatorTests
{
    public class StringCalculatorTests
    {
        [Test]
        public void should_count_sum_of_empty_string_as_zero()
        {
            // arrange
            const string numbers = "";
            var calc = new StringCalculator();

            // act
            var actual = calc.Add(numbers);

            // assert
            actual.Should().Be(0);
        }
    }
}
