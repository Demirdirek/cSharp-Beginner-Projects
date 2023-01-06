using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the game board
            char[,] board = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }

            // Initialize the players
            char player1 = 'X';
            char player2 = 'O';
            char currentPlayer = player1;

            // Initialize the game loop
            bool gameOver = false;
            while (!gameOver)
            {
                // Display the board
                Console.Clear();
                DrawBoard(board);

                // Get the player's move
                Console.WriteLine($"{currentPlayer}'s turn. Enter row and column (e.g. 0 1):");
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                // Make the move
                if (board[row, col] == ' ')
                {
                    board[row, col] = currentPlayer;
                }
                else
                {
                    Console.WriteLine("That space is already occupied. Try again.");
                    continue;
                }

                // Check if the game is over
                if (IsGameOver(board))
                {
                    gameOver = true;
                    Console.Clear();
                    DrawBoard(board);
                    Console.WriteLine($"{currentPlayer} wins!");
                }

                // Switch players
                if (currentPlayer == player1)
                {
                    currentPlayer = player2;
                }
                else
                {
                    currentPlayer = player1;
                }
            }
        }

        static void DrawBoard(char[,] board)
        {
            // Draw the top row
            Console.WriteLine("  0 1 2");

            // Draw the rows of the board
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("  -----");
                }
            }
        }

        static bool IsGameOver(char[,] board)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                {
                    return true;
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != ' ')
                {
                    return true;
                }
            }

            // Check diagonal 1
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            {
                return true;
            }

            // Check diagonal 2
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            {
                return true;
            }

            // If none of the above conditions are met, the game is not over
            return false;
        }
    }
}

/*
To run this program, you'll need to compile it using a C# compiler and then run the resulting executable file.
You can do this using the command line by typing csc <filename>.cs to compile the code and then <filename>.exe to run it.
*/
