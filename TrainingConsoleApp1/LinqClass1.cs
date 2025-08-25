using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrainingConsoleApp1
{
    internal class LinqClass1
    {
        public void LinqOperations()
        {
            // Example of LINQ operations
            Console.WriteLine("===== LINQ Operations =====");
        // sample data
          
        }
        public void nwwdn()
        {
        var numbs= new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            // Filtering even numbers
            var evenNumbers = numbs.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
            // Finding the first number greater than 10
            var firstGreaterThanTen = numbs.FirstOrDefault(n => n > 10);
            Console.WriteLine("First number greater than 10: " + firstGreaterThanTen);
            // Grouping numbers by their remainder when divided by 3
            var groupedByRemainder = numbs.GroupBy(n => n % 3);
            foreach (var group in groupedByRemainder)
            {
                Console.WriteLine($"Numbers with remainder {group.Key}: {string.Join(", ", group)}");
            }
            // Sorting numbers in descending order
            var sortedNumbers = numbs.OrderByDescending(n => n);
            Console.WriteLine("Sorted Numbers (Descending): " + string.Join(", ", sortedNumbers));
        }
    }
}
