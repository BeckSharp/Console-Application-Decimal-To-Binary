using System;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 3684;

            string binary = decimalToBinary(input);

            Console.WriteLine(input + " converted to Binary is: " + binary);
        }

        static string decimalToBinary(int input) 
        {   
            string binary = "";

            while (input > 0) 
            {
                binary = (input % 2) + binary;
                input = ((input - (input % 2)) / 2);
            }

            return binary;
        }
    }
}