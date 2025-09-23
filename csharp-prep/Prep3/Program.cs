using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        bool playingGame = true;
        while (playingGame == true)
        {
            Random randomGen = new Random();
            int magicNumber = randomGen.Next(1, 100);
            int guess = 0;
            int guessCounter = 0;
            while (magicNumber != guess)
            {
                guessCounter++;
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCounter} guesses to get the right answer.");
                    Console.WriteLine("Would you like to play again? (y/n)");
                    string playAgain = Console.ReadLine().ToLower();
                    if (playAgain == "y")
                    {
                        playingGame = true;
                    }
                    else
                    {
                        playingGame = false;
                    }
                }
            }
        }
    }
}