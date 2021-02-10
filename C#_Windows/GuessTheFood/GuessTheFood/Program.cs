using System;
using System.Collections.Generic;

namespace GuessTheFood
{
    class Program
    {
        static void Main(string[] args)
        {
            //On Start
            string greeting = "Hello! Below are foods available, please guess the correct one:";
            Console.WriteLine(greeting);

            //List of 5 foods
            string[] food = { "Pizza", "Pasta", "Salmon", "Steak", "Miso" };
            List<string> foodList = new List<string>(food);

            foreach (string a in food)
                Console.WriteLine(a);

            /// Create a Random Selection <see cref="!:https://www.c-sharpcorner.com/article/how-to-select-a-random-string-from-an-array-of-strings/"></see>
            Random random = new Random();

            // Generate a random index less than the size of the array.  
            int index = random.Next(food.Length);

            // Generate the correct guess 
            string correctGuess = ($"{food[index]}");

            // Start guess in a blank string
            string guess = "";

            // Start guess count at 0
            int attempts = 0;

            // Set guess limit at 3
            int guessLimit = 3;

            // Set guesses 
            bool noGuesses = false;


            while (guess != correctGuess && !noGuesses)
            {
                if (attempts < guessLimit)
                {
                    string input = Console.ReadLine();
                    guess = input;
                    attempts++;
                    Console.WriteLine("Wrong, please try again! You have " + (guessLimit - attempts) + " tries left.");
                }
                else
                {
                    noGuesses = true;
                }

            }
            if (noGuesses)

            {
                Console.WriteLine("Wrong, out of guesses!");
            }
            else
            {

                Console.WriteLine("Congratulations!");
            }
        }
    }
}