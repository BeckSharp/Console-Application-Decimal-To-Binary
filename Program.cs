using System;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = getInput();;

            string binary = decimalToBinary(input);

            Console.WriteLine(input + " converted to Binary is: " + binary);
            Environment.Exit(0);
        }

        static int getInput() 
        {
            try
            {
                Console.WriteLine("Please enter a valid number to convert to binary:");
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch {
                Console.WriteLine("Error occurred: Invalid input entered!");
                return getInput();
            }
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