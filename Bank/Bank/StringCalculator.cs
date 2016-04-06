using System;
using System.Text.RegularExpressions;

namespace StringCalculatorNS
{
    /// <summary> 
    /// Bank Account demo class. 
    /// </summary> 
    public class StringCalculator
    {
        public int sum = 0;

        public StringCalculator()
        {
        }

        public void Add (string numbers)
        {
            string pattern = ",";
            string[] numbersArray = Regex.Split(numbers, pattern);
            if (numbersArray.Length > 0)
            {
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    sum += Int32.Parse(numbersArray[i]);
                }
            }
            System.Console.WriteLine(sum);
        }

    }
}