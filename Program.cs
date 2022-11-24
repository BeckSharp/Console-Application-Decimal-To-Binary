using System;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean runProgram = true;

            while (runProgram) 
            {
                int input = getInput();

                string binary = decimalToBinary(input);

                Console.WriteLine(input + " converted to Binary is: " + binary);

                runProgram = convertAnotherNumber();
            }

            Console.WriteLine("Application Closed");
            Environment.Exit(0);
        }

        static int getInput() 
        {
            try
            {
                Console.WriteLine("Please enter a valid positive integer to convert to binary:");
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

            if (input == 0) { return "0"; }

            while (input > 0) 
            {
                binary = (input % 2) + binary;
                input = ((input - (input % 2)) / 2);
            }

            return binary;
        }

        static Boolean convertAnotherNumber()
        {
            try
            {
                Console.WriteLine("Would you like to convert another number? (yes/no)");
                string? answer = Console.ReadLine();
                if (answer != null) { answer = answer.ToLower(); }

                if (answer == "yes") { return true; }
                
                if (answer == "no") 
                { 
                    return false; 
                } 
                else 
                { 
                    Console.WriteLine("Error occurred: Please enter a valid answer!"); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred: " + e);
                return convertAnotherNumber();
            }
            return convertAnotherNumber();
        }
    }
}