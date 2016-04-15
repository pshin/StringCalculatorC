using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculatorNS
{
    public class StringCalculator
    {
        public string Pattern = @"\D|\n";
        public int Sum = 0;

        public StringCalculator()
        {
        }

        public int Add (string numbers)
        {
            if (!String.IsNullOrEmpty(numbers)) {
                var matches = new Regex("\\d+").Match(numbers);
                while (matches.Success)
                {
                    Sum += int.Parse(matches.Value);
                    matches = matches.NextMatch();
                }
            }
            return Sum;
        }

    }
}