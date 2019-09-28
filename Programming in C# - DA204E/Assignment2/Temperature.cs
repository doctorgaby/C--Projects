/*
 * Created: Bulai Gabriel, 2019-09-28
 * This class serves to fullfill the special requirements of the assignment
 * As it was more flexible, I decided on the implementation
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Temperature
    {
        //variables declaration
        private decimal valueToConvert;
        private List<decimal> degreesList;
        private int choiceSwitch = -1;

        public void Start()
        {
            while (choiceSwitch != 0)
            {
                //show the Menu
                WriteMenuText();
                //read input from the user and match it with switch cases
                choiceSwitch = Input.ReadIntegerConsole();
                switch (choiceSwitch)
                {
                    case 1:
                        Console.WriteLine("Insert celsius value to transform to fahrenheit: ");
                        ReadInputAndSaveNumbers(1);
                        Console.WriteLine("------------------------------------------------" + Environment.NewLine);
                        break;
                    case 2:
                        Console.WriteLine("Insert fahrenheit value to transform to celsius: ");
                        ReadInputAndSaveNumbers(2);
                        Console.WriteLine("------------------------------------------------" + Environment.NewLine);
                        break;
                    case 3:
                        Console.WriteLine("Insert fahrenheit value to transform to celsius: ");
                        ReadInputAndSaveNumbers(2);
                        Console.WriteLine("------------------------------------------------" + Environment.NewLine);
                        break;
                    case 0:
                        choiceSwitch = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
        //implemented the two suggested hints for conversion as methods
        private decimal ToCelsius(decimal i){
            valueToConvert = 5.0m / 9.0m * (i - 32);
            return Math.Round(valueToConvert, 2);
        }
        private decimal ToFahrenheit(decimal i)
        {
            valueToConvert = 9.0m / 5.0m * i + 32.0m;
            return Math.Round(valueToConvert, 2);
        }

        public void ReadInputAndSaveNumbers(int j)
        {
            //values will be stored in a list of decimals
            degreesList = new List<decimal>();
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Write the degrees to convert; press q to finish ");
                decimal num = Input.ReadDecimalConsole();
                //receive 2 from the helper method if q is inserted and terminate the loop
                if (num == 2.18923412m)
                    done = true;
                else degreesList.Add(num);
            }
            //stringbuilder is used take each value in the list and display it vertically
            StringBuilder str = new StringBuilder();
            int count = 1;
            foreach (decimal i in degreesList)
            {
                //j is the variable that is passed from the switch case, in order to know which conversion method to use
                if(j==1)
                    Console.WriteLine("\t" + i + " C\t = \t" + ToFahrenheit(i) + " F");
                else
                    Console.WriteLine("\t" + i + " F\t = \t" + ToCelsius(i) + " C");
                //append a backspace for each line
                if (count % 1 == 0)
                    str.Append("\n");
                count++;
            }
            Console.Write(str);
        }
        //display Menu
        private void WriteMenuText()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("                Temperature Table");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1\tConvert Cesius (C) to Fahrenheit (F)");
            Console.WriteLine("2\tConvert Fahrenheit (F) to Celsius (C)");
            Console.WriteLine("0\tReturn to the Main Menu");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Your Choice: ");
        }
    }
}