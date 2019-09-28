/*
 * Created: Bulai Gabriel, 2019-09-28
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class WorkingSchedule
    {
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
                        Console.WriteLine("Your schedule of the above option is as follows" + Environment.NewLine);
                        for (int i = 1; i <= 52; i += 3)
                        {
                            /* in this case the formating string can be used as 52 can be divided into 3 rows without
                             * exceeding the limits
                             */
                            Console.WriteLine("\tWeek{0,5}\tWeek{1,5}\tWeek{2,5}", i, i += 3, i += 3);
                        }
                        Console.WriteLine("------------------------------------------------" + Environment.NewLine);
                        break;
                    case 2:
                        Console.WriteLine("Your schedule of the above option is as follows" + Environment.NewLine);
                        List<int> numberList = new List<int>();
                        for (int i = 6; i < 52; i += 5)
                            numberList.Add(i);
                        //stringbuilder object is created in order to avoid going off-limits and at the same time 
                        //displaying the output in an ordered way.
                        StringBuilder str = new StringBuilder();
                        int count = 1;
                        foreach (int i in numberList)
                        {
                            str.Append("\tWeek\t " + i.ToString());
                            //append a backspace each 3
                            if (count % 3 == 0)
                                str.Append("\n");
                            count++;
                        }
                        Console.Write(str);
                        Console.WriteLine(Environment.NewLine + "------------------------------------------------" + Environment.NewLine);
                        break;
                    case 0:
                        //Console.WriteLine("Your Choice:\t 0");
                        choiceSwitch = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
        //display the option menu
        private void WriteMenuText()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("                WORK SCHEDULE PROGRAM");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1\tShow a list of the weekends to work");
            Console.WriteLine("2\tShow a list of the nights to work");
            Console.WriteLine("0\tReturn to the Main Menu");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Your Choice: ");
        }
    }
}
