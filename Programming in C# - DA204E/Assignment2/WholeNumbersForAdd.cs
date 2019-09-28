/*
 * Created: Bulai Gabriel, 2019-09-28
 */
using System;
namespace Assignment2
{
    public class WholeNumbersForAdd
    {
        //variables declaration
        private int numberOfInputs;
        private int summation;

        //read user input --> how many integers are to be added
        public void ReadInput()
        {
            Console.WriteLine("Numbers of values to sum?");
            numberOfInputs = Input.ReadIntegerConsole(); 
            Console.WriteLine();
        }
        public void Start()
        {
            WriteProgramInfo();
            ReadInput();
            SumNumbers();
            WriteResult();

        }
        //sum the numbers received in a loop
        private void SumNumbers()
        {
            for (int i = 1; i <= numberOfInputs; i++)
            {
                for (int j = i; j <= numberOfInputs; j++)
                {
                    Console.Write("Please give the value of no " + i + "(whole number) :" + System.Environment.NewLine);
                    summation += Input.ReadIntegerConsole();
                    i++;
                }
            } 
        }
        //display option menu
        private void WriteProgramInfo()
        {
            Console.WriteLine("++++++\tSummation of whole numbers\t++++++");
            Console.WriteLine("         Using a for-statement");

        }
        //write the result
        private void WriteResult()
        {
            Console.Write("The sum is       " + summation + Environment.NewLine);
        }

    }
}
