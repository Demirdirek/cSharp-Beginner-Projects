using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===============================================");
            Console.WriteLine("|||||||||||||DEMIRDIREK INDUSTRIES|||||||||||||");
            Console.WriteLine("===============================================");

            do
            {
                try
                {
                    int choise = 0;

                    Console.WriteLine("===============================================");
                    Console.WriteLine("                1 for Calculator               ");
                    Console.WriteLine("             2 for Binary to Decimal           ");
                    Console.WriteLine("           3 for Binary to Hypotenuse          ");
                    Console.WriteLine("===============================================");
                    choise = Convert.ToInt32(Console.ReadLine());

                    if (choise == 1)
                    {
                        //x = Calculator, y = Decimal To Binary

                        //Calculator Variables

                        double number1 = 0, number2 = 0, result = 0;

                        Calculator(number1, number2, result);
                    }

                    else if (choise == 2)
                    {
                        //Decimal to Binary Variables

                        int n = 0, k = 0, i = 0;
                        string str = "", bin = "";

                        decimalTObinary(n, k, i, str, bin);
                    }

                    else
                    {
                        // Hypotenuse Program

                        double a = 0, b = 0, c = 0;

                        z(a, b, c);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter the shit correct idiot!");
                }

                Console.WriteLine("===============================================");
                Console.WriteLine("       Would you like clear screen? (Y/N)      ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.Clear();
                }

                Console.WriteLine("===============================================");
                Console.WriteLine("       Would you like to continue? (Y/N)       ");
                Console.WriteLine("===============================================");
            }
            while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("===============================================");
            Console.WriteLine("                      Bye!                     ");
            Console.WriteLine("===============================================");

            Console.ReadKey();
        }

        static void Calculator(double number1, double number2, double result)
        {

            Console.WriteLine("===============================================");
            Console.WriteLine("First Number");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second Number");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");
            Console.Write("Enter an option: ");

            switch (Console.ReadLine())
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine("===============================================");
                    Console.WriteLine($"Answer: {number1} + {number2} = " + result);
                    break;
                case "-":
                    result = number1 - number2;
                    Console.WriteLine("===============================================");
                    Console.WriteLine($"Answer: {number1} - {number2} = " + result);
                    break;
                case "*":
                    result = number1 * number2;
                    Console.WriteLine("===============================================");
                    Console.WriteLine($"Answer: {number1} * {number2} = " + result);
                    break;
                case "/":
                    result = number1 / number2;
                    Console.WriteLine("===============================================");
                    Console.WriteLine($"Answer: {number1} / {number2} = " + result);
                    break;
                default:
                    Console.WriteLine("That was not a valid option!");
                    break;
            }
        }

        static void decimalTObinary(int n, int k, int i, string str, string bin)
        {
            Console.WriteLine("Ener Any Number ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n >= 1)
            {
                k = n / 2;
                str = str + (n % 2).ToString();
                n = k;
            }
            for (i = str.Length - 1; i >= 0; i--)
            {
                bin = bin + str[i];
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("The Binary Format is " + bin);
        }

        static void z(double a, double b, double c)
        {
            Console.WriteLine("Enter side A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            b = Convert.ToDouble(Console.ReadLine());

            c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("===============================================");
            Console.WriteLine("The hypotenuse is: " + c);
        }
    }
}
