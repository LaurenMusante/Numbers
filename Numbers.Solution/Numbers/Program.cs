//frontend
using System;
using Converter;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number and we will convert it into word-form:");
        string input = Console.ReadLine();
        NumberConverter converterBoy = new NumberConverter();
        Console.WriteLine(converterBoy.ConvertToWords(input));
    }
}