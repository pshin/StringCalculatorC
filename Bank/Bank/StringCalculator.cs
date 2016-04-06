using System;
using System.Text.RegularExpressions;

namespace StringCalculatorNS
{
    /// <summary> 
    /// Bank Account demo class. 
    /// </summary> 
    public class StringCalculator
    {
        public string pattern = ",";
        public int sum = 0;

        public StringCalculator()
        {
        }

        public void Add (string numbers)
        {
            if (!String.IsNullOrEmpty(numbers)) {
                Array.ForEach(Regex.Split(numbers, pattern), number =>
                {
                    sum += Int32.Parse(number);
                });
            }
        }

    }
}