/*
 * Created: Bulai Gabriel, 2019-09-28
 */
using System;
namespace Assignment2
{
    public static class Input
    {
        //this method reads an integer from console untill a correct integer is received
        public static int ReadIntegerConsole()
        {
            if (int.TryParse(Console.ReadLine(), out int input))
                return input;
            Console.WriteLine("Wrong input, Please try again: ");
            return ReadIntegerConsole();
        }
        //this method reads a double from console untill a correct double is received
        public static double ReadDoubleConsole()
        {
            if (double.TryParse(Console.ReadLine(), out double input))
                return input;
            Console.WriteLine("Wrong input, Please try again: ");
            return ReadDoubleConsole();
        }
        //this method reads a decimal from console and rounds it to 2 decimal places
        public static decimal ReadDecimalConsole()
        {
            //exit solution for the temperature class
            string error = "q";
            string readingString = Console.ReadLine();
            if (decimal.TryParse(readingString, out decimal input))
                return Math.Round(input, 2);
            if (readingString == error)
                //return this number to check and exit the loop
                return 2.18923412m;
            Console.WriteLine("Wrong input, Please try again: ");
            return ReadDecimalConsole();
        }
        /*this method is specifically for the currencyConverter class and forces
         * the input to be chosen between Eur and Sek only
         */
        public static string ReadStringConsole()
        {
            string line = Console.ReadLine();
            string a = "Eur";
            string b = "Sek";
            if (line == a)
                return a;
            if (line == b)
                return b;
            Console.WriteLine("Choose between Eur or Sek!");
            return ReadStringConsole();
        }

    }
}
