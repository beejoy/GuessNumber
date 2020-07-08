using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = new Random().Next(101);

            Console.WriteLine("Welcome Contestant!");
            do
            {
                int userGuess = -1;
                Console.WriteLine("Take a guess what I'm thinking... Any number between 0 and 100.");
                if (int.TryParse(Console.ReadLine(), out userGuess))
                {
                    if (userGuess == numberToGuess)
                    {
                        break;
                    }
                    Console.WriteLine($"Not quite. I'm thinking of a number that is {(userGuess > numberToGuess ? "lower" : "higher")}.");
                }
                else
                {
                    userGuess = -1;
                    Console.WriteLine("Please enter a numberic value.");
                }
            } while (true);

            Console.WriteLine($"Well done!!! You guessed right. I was thinking of {numberToGuess}.");
            Console.WriteLine("Thanks for playing.");
            Console.ReadLine();
        }
    }
}
