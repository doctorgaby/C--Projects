/*
 * Created: Bulai Gabriel, 2019-09-28
 */
using System;
namespace Assignment2
{
    public class FloatingPointsNumberWhileAdd
    {
        //variables declaration
        private double summation;

        public void Start(){
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowResults();
        }
        //read numbers in a loop untill the user enters 0
        public void ReadInputAndSumNumbers(){
            bool done = false;
            while(!done){
                Console.WriteLine("Write an amount to sum or 0 to finish: ");
                double num = Input.ReadDoubleConsole();
                //check if the number inserted is 0
                if ((Math.Abs(Math.Round(num, 7)) < 0.0000001)){
                    done = true;
                }
                //unless the number is 0, add the number to the variable summation    
                else summation += num;
            }
        //display the program info
        }
        public void WriteProgramInfo(){
            Console.WriteLine("++++++\tSummation of real numbers\t++++++");
            Console.WriteLine("         Using While-statement");
            Console.WriteLine("Write 0 to finish!");
            Console.WriteLine("Make sure to use correct decimal character.");
            Console.WriteLine("-------------------------------------------");
        }
        //show the results
        public void ShowResults(){
            //Console.WriteLine("-------------------------------------------");
            Console.Write("The sum is       " + summation + Environment.NewLine);
        }
    }
}
