using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp1
{
    internal class FibonacciCalculator
    {
        // Recursive method for Fibonacci
        public int Fibonacci(int n)
        {
            if (n <= 1)
                return n; // Base case
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive call
        }
    }
}
