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
                var matches = new Regex("[-\\d]+").Match(numbers);
                while (matches.Success)
                {
                    var number = int.Parse(matches.Value);
                    if (number < 0)
                    {
                        throw new Exception("Negatives not allowed " + number);
                    }
                    else
                    {
                        Sum += number;
                    }
                    matches = matches.NextMatch();
                }
            }
            return Sum;
        }

    }
}