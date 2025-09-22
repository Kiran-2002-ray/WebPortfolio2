using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp1
{
    internal class NumberGuessGame
    {

        public void Game()
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("===== Welcome to the Number Guessing Game =====");
                Console.WriteLine("Select Difficulty Level:");
                Console.WriteLine("1. Easy (1-10, 5 chances)");
                Console.WriteLine("2. Medium (1-50, 7 chances)");
                Console.WriteLine("3. Hard (1-100, 10 chances)");

                int min = 1, max = 10, attempts = 5;
                string difficultyChoice = Console.ReadLine();

                switch (difficultyChoice)
                {
                    case "1":
                        min = 1; max = 10; attempts = 5;
                        break;
                    case "2":
                        min = 1; max = 50; attempts = 7;
                        break;
                    case "3":
                        min = 1; max = 100; attempts = 10;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, defaulting to Easy.");
                        break;
                }

                Random rnd = new Random();
                int secretNumber = rnd.Next(min, max + 1);
                bool guessedCorrectly = false;

                Console.WriteLine($"\nI have selected a number between {min} and {max}. Try to guess it!");
                Console.WriteLine($"You have {attempts} attempts.");

                for (int i = 1; i <= attempts; i++)
                {
                    Console.Write($"\nAttempt {i}: Enter your guess: ");
                    int guess;
                    if (!int.TryParse(Console.ReadLine(), out guess))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        i--; // Don’t count invalid input as an attempt
                        continue;
                    }

                    if (guess == secretNumber)
                    {
                        Console.WriteLine($"🎉 Congratulations! You guessed it in {i} attempts.");
                        guessedCorrectly = true;
                        break;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try a higher number.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try a lower number.");
                    }

                    Console.WriteLine($"Remaining attempts: {attempts - i}");
                }

                if (!guessedCorrectly)
                {
                    Console.WriteLine($"\n❌ You lost! The number was {secretNumber}.");
                }

                Console.Write("\nDo you want to play again? (y/n): ");
                string playChoice = Console.ReadLine().ToLower();
                if (playChoice != "y")
                {
                    playAgain = false;
                }
                Console.Clear();
            }

            Console.WriteLine("Thanks for playing! Goodbye.");
        }

    }
}
