using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // The options the player can choose from
            string[] options = { "rock", "paper", "scissors" };

            // Generate a random number for the computer's choice
            Random rnd = new Random();
            int computerChoice = rnd.Next(0, 3);

            // Get the player's choice
            Console.WriteLine("Enter your choice (rock/paper/scissors):");
            string playerChoice = Console.ReadLine();

            // Compare the choices and determine the winner
            if (playerChoice == options[computerChoice])
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerChoice == "rock" && options[computerChoice] == "scissors" ||
                     playerChoice == "paper" && options[computerChoice] == "rock" ||
                     playerChoice == "scissors" && options[computerChoice] == "paper")
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("The computer wins!");
            }
        }
    }
}
