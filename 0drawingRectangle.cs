using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set the console cursor position and draw a cube
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("+------+");
            Console.SetCursorPosition(10, 6);
            Console.WriteLine("|      |");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("|      |");
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("|      |");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("+------+");

            // Spin the cube by redrawing it at a new location and clearing its previous position
            for (int i = 0; i < 360; i++)
            {
                // Clear the previous position of the cube
                Console.SetCursorPosition(10, 5);
                Console.WriteLine("        ");
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("        ");
                Console.SetCursorPosition(10, 7);
                Console.WriteLine("        ");
                Console.SetCursorPosition(10, 8);
                Console.WriteLine("        ");
                Console.SetCursorPosition(10, 9);
                Console.WriteLine("        ");

                // Calculate the new position of the cube
                int x = (int)(10 + 5 * Math.Cos(i * Math.PI / 180));
                int y = (int)(5 + 5 * Math.Sin(i * Math.PI / 180));

                // Draw the cube at the new position
                Console.SetCursorPosition(x, y);
                Console.WriteLine("+------+");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("|      |");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("|      |");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("|      |");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("+------+");

                // Sleep for a short time to slow down the animation
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
