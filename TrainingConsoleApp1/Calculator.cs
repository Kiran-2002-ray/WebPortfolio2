using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp1
{
    internal class Calculator
    {
        public void CalculatorOperations()
        {
            // Declare variables
            double num1;
            double num2;
            string op; 

            // Ask the user to enter the first number
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the operator
            Console.WriteLine("Enter an operator (+, -, *, /):");
            op = Console.ReadLine();

            // Ask the user to enter the second number
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Perform the calculation based on the operator
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Check for division by zero
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return; // Exit the program
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return; // Exit the program
            }

            // Display the result
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");

            Console.WriteLine("---------------=========================-----------------------");
            // Step 1: Ask the user for a number
            Console.WriteLine("Enter the number:");

            // Step 2: Read and convert the input to an integer
            int number = Convert.ToInt32(Console.ReadLine());

            // Step 3: Calculate the square
            int result1 = number * number;

            // Step 4: Print the result
            Console.WriteLine("The square is: " + result1);
        }
    }
}
