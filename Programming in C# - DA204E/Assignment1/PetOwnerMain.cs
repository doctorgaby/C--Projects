using System;

namespace Assignment1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Arrange Console Window - Settings
			Console.BackgroundColor = ConsoleColor.Gray;
			//Apply the color chosen above
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Title = "Pet Owner";

            //create a new object of type Pet
			Pet pet = new Pet();

            //start the console application
            pet.Start();

		}
	}
}
