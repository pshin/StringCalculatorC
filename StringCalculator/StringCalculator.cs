using System;
using System.Text.RegularExpressions;

namespace StringCalculatorNS
{
    public class StringCalculator
    {
        public string Pattern = @",|\\n";
        public int Sum = 0;

        public StringCalculator()
        {
        }

        public int Add (string numbers)
        {
            if (!String.IsNullOrEmpty(numbers)) {
                Array.ForEach(Regex.Split(numbers, Pattern), number =>
                {
                    Sum += Int32.Parse(number);
                });
            }
            return Sum;
        }

    }
}