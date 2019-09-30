using System;
namespace Assignment1
{
    public class Pet
    {
        //instance variables declaration
        private string name;
        private int age;
        private bool isFemale;


        //read user input 
        private void ReadAndSavePetData()
        {
            ReadName();
            ReadAge();
            ReadGender();
        }
        private void ReadName()
        {
            Console.Write("Enter your pet's name: ");
            name = Console.ReadLine();
        }

        private void ReadAge()
        {
            Console.Write("What is " + name + "'s" + " age? ");
            age = int.Parse(Console.ReadLine());
        }

        private void ReadGender()
        {
            Console.Write("Is your pet female? y/n: ");
            //store user reply in a variable
            char response = char.Parse(Console.ReadLine());
            //compare user reply and decide boolean
            if ((response == 'y') || (response == 'Y'))
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
        }

        //display pet information
        private void DisplayPetInfo(){
            Console.WriteLine("Your Pet is called " + name);
            Console.WriteLine(name + " is " + age + " years old");
            if(isFemale){
                Console.WriteLine("She is a female");
            }else{
                Console.WriteLine("He is a male");
            }

        }

        //call all methods at once
        public void Start(){
            Console.WriteLine("Greetings from a Pet Object!" + System.Environment.NewLine);
            ReadAndSavePetData();
            //add line separator
            Console.WriteLine(Environment.NewLine + "++++++++++++++++++++++++++++" + Environment.NewLine);
            DisplayPetInfo();
            Console.WriteLine(Environment.NewLine + "++++++++++++++++++++++++++++" + Environment.NewLine);
        }
    }
}
