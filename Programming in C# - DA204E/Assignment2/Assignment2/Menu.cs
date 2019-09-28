/*
 * Created: Bulai Gabriel, 2019-09-28
 */
using System;
namespace Assignment2
{
    public class Menu
    {
        public void Start()
        {
            //loop for displaying always the menu
            int choiceSwitch = -1;
            while (choiceSwitch != 0)
            {
                //show the Menu by calling its method
                WriteMenuText();
                //read input from the user and match it with switch cases
                choiceSwitch = Input.ReadIntegerConsole();
                /*depending on the value of the choice, create an instance of
                 * the class displayed on the menu
                 */
                switch (choiceSwitch)
                {
                    //create whole numbers object if option 1 is chosen
                    case 1:
                        WholeNumbersForAdd wholeNumbersForAdd = new WholeNumbersForAdd();
                        wholeNumbersForAdd.Start();
                        break;
                    //create floating point object if option 2 is chosen
                    case 2:
                        FloatingPointsNumberWhileAdd floatingPointsNumberWhileAdd = new FloatingPointsNumberWhileAdd();
                        floatingPointsNumberWhileAdd.Start();
                        break;
                    //create currency converter object if option 3 is chosen
                    case 3:
                        CurrencyConverter currencyConverter = new CurrencyConverter();
                        currencyConverter.Start();
                        break;
                    // create working schedule object if option 4 is chosen
                    case 4:
                        WorkingSchedule workingSchedule = new WorkingSchedule();
                        workingSchedule.Start();
                        break;
                        //create temperature object if option 5 is chosen(optional requirement)
                    case 5:
                        Temperature temperature = new Temperature();
                        temperature.Start();
                        break;
                    //exit the program if option 0 is chosen
                    case 0:
                        Environment.Exit(0);
                        break;
                    //wait for correct input if the user inserts an inexistent option
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
        //display Menu
        private void WriteMenuText()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("                MAIN MENU");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\tWhole Numbers with For:                   1");
            Console.WriteLine("\tFloating Point Numbers with While:        2");
            Console.WriteLine("\tCurrency Converter with Do While loop:    3");
            Console.WriteLine("\tWork Schedule:                            4");
            Console.WriteLine("\tTemperature Table:                        5");
            Console.WriteLine("\tExit the program:                         0");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Your Choice: ");
        }
    }
}
