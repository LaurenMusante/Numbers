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
            TenThousands = new Dictionary<char, string>() { {'0', "0"}, {'1', "ten"}, {'2', "twenty"}, {'3', "thirty"}, {'4', "forty"}, {'5', "fifty"}, {'6', "sixty"}, {'7', "seventy"}, {'8', "eighty"}, {'9', "ninety"} };
            HundredThousands = new Dictionary<char, string>() { {'0', "0"}, {'1', "one hundred"}, {'2', "two hundred"}, {'3', "three hundred"}, {'4', "four hundred"}, {'5', "five hundred"}, {'6', "six hundred"}, {'7', "seven hundred"}, {'8', "eight hundred"}, {'9', "nine hundred"} };
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
                string outputOnes = "";
                string outputTens = "";
                string outputHundreds = "";
                string outputThousands = "";
                string outputTenThousands = "";
                string outputHundredThousands = "";
                for (int i = 0; i < 6-input.Length; i++)
                {
                    zeros += "0";
                }
                string number = zeros + input;
                Console.WriteLine(number);
                char[] numberChars = number.ToCharArray();
                char[] thousandsChars = new char[3]; //to process the three digits in the thousands chunk (ie. 360 of 360,281)
                char[] hundredsChars = new char[3]; //to process the three digits in the hundreds chunk (ie. 281 of 360,281)

                for (int i = 0; i < 3; i++)
                {
                    thousandsChars[i] = numberChars[i];

                }
                for (int i = 0; i < 3; i++)
                {
                    hundredsChars[i] = numberChars[i+3];
                }

                string thousandsChunk = "";
                string hundredsChunk = "";
                if (thousandsChars[1] == '1')
                {
                    if (thousandsChars[2] == '0')
                    {
                        thousandsChunk = "ten";
                    }
                    if (thousandsChars[2] == '1')
                    {
                        thousandsChunk = "eleven";
                    }
                    if (thousandsChars[2] == '2')
                    {
                        thousandsChunk = "twelve";
                    }
                    if (thousandsChars[2] == '3')
                    {
                        thousandsChunk = "thirteen";
                    }
                    if (thousandsChars[2] == '4')
                    {
                        thousandsChunk = "fourteen";
                    }
                    if (thousandsChars[2] == '5')
                    {
                        thousandsChunk = "fifteen";
                    }
                    if (thousandsChars[2] == '6')
                    {
                        thousandsChunk = "sixteen";
                    }
                    if (thousandsChars[2] == '7')
                    {
                        thousandsChunk = "seventeen";
                    }
                    if (thousandsChars[2] == '8')
                    {
                        thousandsChunk = "eighteen";
                    }
                    if (thousandsChars[2] == '9')
                    {
                        thousandsChunk = "nineteen";
                    }
                }
                if (hundredsChars[1] == '1')
                {
                    if (hundredsChars[2] == '0')
                    {
                        hundredsChunk = "ten";
                    }
                    if (hundredsChars[2] == '1')
                    {
                        hundredsChunk = "eleven";
                    }
                    if (hundredsChars[2] == '2')
                    {
                        hundredsChunk = "twelve";
                    }
                    if (hundredsChars[2] == '3')
                    {
                        hundredsChunk = "thirteen";
                    }
                    if (hundredsChars[2] == '4')
                    {
                        hundredsChunk = "fourteen";
                    }
                    if (hundredsChars[2] == '5')
                    {
                        hundredsChunk = "fifteen";
                    }
                    if (hundredsChars[2] == '6')
                    {
                        hundredsChunk = "sixteen";
                    }
                    if (hundredsChars[2] == '7')
                    {
                        hundredsChunk = "seventeen";
                    }
                    if (hundredsChars[2] == '8')
                    {
                        hundredsChunk = "eighteen";
                    }
                    if (hundredsChars[2] == '9')
                    {
                        hundredsChunk = "nineteen";
                    }
                }
                


                if (numberChars[5] != '0')
                {
                    outputOnes = Ones[numberChars[5]];
                }
                if (numberChars[4] != '0')
                {
                    outputTens = Tens[numberChars[4]] + " ";
                }
                if (numberChars[3] != '0')
                {
                    outputHundreds = Hundreds[numberChars[3]] + " ";
                }
                if (numberChars[2] != '0')
                {
                    outputThousands = Thousands[numberChars[2]] + " ";
                }
                if (numberChars[1] != '0')
                {
                    outputTenThousands = TenThousands[numberChars[1]] + " ";
                }
                if (numberChars[0] != '0')
                {
                    outputHundredThousands = HundredThousands[numberChars[0]] + " ";
                }

                
                // output = outputHundredThousands + outputTenThousands + outputThousands + outputHundreds + outputTens + outputOnes;
                output = Hundreds[thousandsChars[0]] + " " + thousandsChunk + " thousand " + Hundreds[hundredsChars[0]] + " " + hundredsChunk;
            }
            return output;
        }
    }
}