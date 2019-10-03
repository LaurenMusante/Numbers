//backend
using System.Text.RegularExpressions;

namespace Converter
{
    public class NumberConverter
    {
        public string ConvertToWords(string input)
        {
            string output = "";
            Regex regex = new Regex(@"[^0-9]");
            Match match = regex.Match(input);
            if (match.Success || input.Length < 1) 
            {
                output = "Numerical input only! Please try again.";
            }
            return output;
        }
    }
}