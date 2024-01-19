using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isRunning;

            do
            {
                Console.WriteLine("-----------------------\n* Simple Calculator *\n-----------------------\n");

                Console.Write("Enter the first number: ");
                var operand1 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Enter the second number: ");
                var operand2 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nChoose an operation: \n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n");
                Console.Write("Enter the operation number (1-4): ");
                var operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        Console.WriteLine($"Result of Addition: {operand1 + operand2}");
                        break;
                    case "2":
                        Console.WriteLine($"Result of Subtraction: {operand1 - operand2}");
                        break;
                    case "3":
                        Console.WriteLine($"Result of Multiplication: {operand1 * operand2}");
                        break;
                    case "4":
                        while (operand2 == 0)
                        {
                            Console.Write("Enter a non-zero divisor: ");
                            operand2 = Convert.ToSingle(Console.ReadLine());
                        }
                        Console.WriteLine($"Result of Division: {operand1 / operand2}");
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }

                Console.WriteLine("\nDo you want to continue(y/n): ");
                isRunning = Console.ReadLine();
            }

            while (isRunning == "y" || isRunning == "Y");
        }
    }
}
