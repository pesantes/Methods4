/*
Author: Fernando Pesantes
Date: 1/31/2019
Description: Methods class project

*/

using System;

namespace Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name");
            Console.ReadKey(true);
            try
            {
                string input = Console.ReadLine();
                DisplayName(input);
            } // End of try
            catch
            {
                Console.WriteLine("Please enter your name next time");
            }// End of catch
        }

        // Method to display user input with a greeting. 
        private static void DisplayName(string input)
        {
            string FullName = input;
            Console.WriteLine("");
            Console.WriteLine("Hello " + input);
            Console.ReadKey(true);
        }// End of method

    } // end of class

} // End of namespace
