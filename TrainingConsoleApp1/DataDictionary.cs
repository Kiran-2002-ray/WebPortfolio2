using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp1
{
    internal class DataDictionary
    {
        
         
        public void SearchCapital()
         {
               // Step 1: Create and populate dictionary
                    Dictionary<string, string> countryCapitals = new Dictionary<string, string>()
                   {
                       { "USA", "Washington, D.C." },
                        { "Canada", "Ottawa" },
                        { "Mexico", "Mexico City" },
                        { "UK", "London" },
                        { "France", "Paris" },
                        { "Germany", "Berlin" },
                        { "Japan", "Tokyo" },
                        { "China", "Beijing" },
                        { "India", "New Delhi" },
                        { "Brazil", "Brasília"}
                    };
            Console.WriteLine("===== Country Capital Search =====");
            Console.WriteLine("Enter a country name to find its capital:");
            Console.WriteLine("Type 'exit' to quit.\n");

            // search for loops
            while (true)
            {
                Console.Write("Entry Country:");
                string country = Console.ReadLine().Trim();
                //exit condition
                if(country.ToLower() == "exit")
                {
                    break;
                }
                //search in dictionary
                if(countryCapitals.ContainsKey(country))
                {
                    Console.WriteLine($"The capital of {country} is {countryCapitals[country]}.\n");
                }
                else
                {
                    Console.WriteLine($"Sorry, the capital of {country} is not in the dictionary.\n");

                //Optional: Ask if user wants to add it
                    Console.Write("Do you want to add it? (yes/no): ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "yes")
                    {
                        Console.Write("Enter capital: ");
                        string capital = Console.ReadLine();
                        countryCapitals[country] = capital;
                        Console.WriteLine("Country and capital added successfully!\n");
                    }
                }
            }

        }
    }
}
