//backend
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Converter
{
    public class NumberConverter
    {
        public Dictionary<char, string> Ones { get; set; }
        public Dictionary<char, string> Tens { get; set; }
        public Dictionary<char, string> Hundreds { get; set; }
        public Dictionary<char, string> Thousands { get; set; }
        public Dictionary<char, string> TenThousands { get; set; }
        public Dictionary<char, string> HundredThousands { get; set; }


        public NumberConverter()
        {
            Ones = new Dictionary<char, string>() { {'0', ""}, {'1', "one"}, {'2', "two"}, {'3', "three"}, {'4', "four"}, {'5', "five"}, {'6', "six"}, {'7', "seven"}, {'8', "eight"}, {'9', "nine"} };
            Tens = new Dictionary<char, string>() { {'0', "0"}, {'1', ""}, {'2', "twenty"}, {'3', "thirty"}, {'4', "forty"}, {'5', "fifty"}, {'6', "sixty"}, {'7', "seventy"}, {'8', "eighty"}, {'9', "ninety"} };
            Hundreds = new Dictionary<char, string>() { {'0', "0"}, {'1', "one hundred"}, {'2', "two hundred"}, {'3', "three hundred"}, {'4', "four hundred"}, {'5', "five hundred"}, {'6', "six hundred"}, {'7', "seven hundred"}, {'8', "eight hundred"}, {'9', "nine hundred"} };
            Thousands = new Dictionary<char, string>() { {'0', "0"}, {'1', "one thousand"}, {'2', "two thousand"}, {'3', "three thousand"}, {'4', "four thousand"}, {'5', "five thousand"}, {'6', "six thousand"}, {'7', "seven thousand"}, {'8', "eight thousand"}, {'9', "nine thousand"} };
            TenThousands = new Dictionary<char, string>() { {'0', "0"}, {'1', "ten thousand"}, {'2', "twenty thousand"}, {'3', "thirty thousand"}, {'4', "forty thousand"}, {'5', "fifty thousand"}, {'6', "sixty thousand"}, {'7', "seventy thousand"}, {'8', "eighty thousand"}, {'9', "ninety thousand"} };
            HundredThousands = new Dictionary<char, string>() { {'0', "0"}, {'1', "one hundred thousand"}, {'2', "two hundred thousand"}, {'3', "three hundred thousand"}, {'4', "four hundred thousand"}, {'5', "five hundred thousand"}, {'6', "six hundred thousand"}, {'7', "seven hundred thousand"}, {'8', "eight hundred thousand"}, {'9', "nine hundred thousand"} };
          }

        public string ConvertToWords(string input)
        {
            string output = "";
            Regex regex = new Regex(@"[^0-9]");
            Match match = regex.Match(input);
            if (match.Success || input.Length < 1) 
            {
                output = "Numerical input only! Please try again.";
            }
            else 
            {
                string zeros = "";
                for (int i = 0; i < 6-input.Length; i++)
                {
                    zeros += "0";
                }
                string number = zeros + input;
                Console.WriteLine(number);
                char[] numberChars = number.ToCharArray();

                string outputOnes = Ones[numberChars[5]];
                string outputTens = Tens[numberChars[4]];
                string outputHundreds = Hundreds[numberChars[3]];
                string outputThousands = Thousands[numberChars[2]];
                string outputTenThousands = TenThousands[numberChars[1]];
                string outputHundredThousands = HundredThousands[numberChars[0]];

                output = outputHundredThousands + outputTenThousands + outputThousands +outputHundreds + outputTens + outputOnes;

            }
            return output;
        }
    }
}