/*
 * Created: Bulai Gabriel, 2019-09-28
 */
using System;
namespace Assignment2
{
    public class CurrencyConverter
    {
        //variables declaration
        private decimal summation;
        private string currency;
        private decimal rate;

        public void Start()
        {
            WriteProgramInfo();
            ReadInputAndConvert();
            ConvertAndShowResults(summation);
        }
        // write current option info
        public void WriteProgramInfo()
        {
            Console.WriteLine("++++++\tThe Currency Converter\t++++++" + Environment.NewLine);
            Console.WriteLine("Write 0 to finish input!");
            Console.WriteLine("Make sure to use correct decimal character." + Environment.NewLine);
        }
        //read user input
        public void ReadInputAndConvert()
        {
            bool done = false;
            do
            {
                Console.WriteLine("Write an amount to sum or 0 to finish: ");
                decimal num = Input.ReadDecimalConsole();
                if (num == 0){
                    done = true;
                }
                // if the number inserted is not 0, add it to the sum variable    
                else summation += num;
            } while (!done);
        }
        //currency conversion method
        public decimal ConvertAndShowResults(decimal d)
        {
            Console.WriteLine("Name of the foreign currency: ");
            //use the helper input class to continuously read the string
            currency = Input.ReadStringConsole();
            Console.WriteLine("Exchange Rate: ");
            rate = Input.ReadDecimalConsole();
            Console.WriteLine(Environment.NewLine + "-------------------");
            //switch the currency input Eur or Sek and provide with the calculus
            switch (currency)
            {
                case "Eur":
                    d /= rate;
                    Console.WriteLine("The sum is " + summation + " Sek" + Environment.NewLine);
                    //round the decimal variable at 2 decimal places
                    Console.WriteLine(summation + " Sek is converted to " + Math.Round(d, 2) + " Euro at the rate of "+ rate + " Sek/Eur");
                    break;
                case "Sek":
                    d *= rate;
                    Console.WriteLine("The sum is " + summation + " Eur" + Environment.NewLine);
                    Console.WriteLine(summation + " Eur is converted to " + Math.Round(d, 2) + " Sek at the rate of " + rate + " Eur/Sek");
                    break;
            }
            return Math.Round(d, 2);
        }
    }
}
