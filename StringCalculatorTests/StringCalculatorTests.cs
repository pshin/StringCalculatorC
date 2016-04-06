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

        [Test]
        public void should_count_sum_of_one_argument()
        {
            // arrange
            const string numbers = "1";
            var calc = new StringCalculator();

            // act
            var actual = calc.Add(numbers);

            // assert
            actual.Should().Be(1);
        }

        [Test]
        public void should_count_sum_of_two_arguments()
        {
            // arrange
            const string numbers = "1,2";
            var calc = new StringCalculator();

            // act
            var actual = calc.Add(numbers);

            // assert
            actual.Should().Be(3);
        }

        [Test]
        public void should_count_sum_of_more_than_two_arguments()
        {
            // arrange
            const string numbers = "1,2,3";
            var calc = new StringCalculator();

            // act
            var actual = calc.Add(numbers);

            // assert
            actual.Should().Be(6);
        }
    }
}
