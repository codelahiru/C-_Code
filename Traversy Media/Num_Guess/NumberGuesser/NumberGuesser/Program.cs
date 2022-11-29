using System;

namespace NumberGuesser
{
    class Program
    { 
        static void Main(string[] args)
        {
            String name = "Gayan";
            int age = 38;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello "+ name);
            Console.WriteLine("{0} is {1} years old", name, age);
            Console.ResetColor();

            Console.WriteLine("What is your name ");

            string inputName = Console.ReadLine();

            // init correct number & init guess number
            int correctNumber = 7;
            int guess = 0;

            Console.WriteLine("Hi " + inputName + " Guess a number between 0 and 10");

            while (guess != correctNumber){

                string input = Console.ReadLine();
                guess = Int32.Parse(input);

                // match guess to correct number

                if (guess != correctNumber) {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong entry. Try again!");
                    Console.ResetColor();

                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are correct!");
            Console.ResetColor();




        }
    }
}
