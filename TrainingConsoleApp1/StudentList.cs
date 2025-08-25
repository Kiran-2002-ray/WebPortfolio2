using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp1
{
    internal class StudentList
    {
            public List<string> students = new List<string>();
        public void ListOfStudents()
        {
            Console.WriteLine("===== Student List Management =====");
            //create a list of strings

            Console.WriteLine("Enter student names:");
            Console.WriteLine("Enter the number of student in a list:");

            int length = int.Parse(Console.ReadLine());
            
             for (int i = 0; i< length; i++)
			{
                Console.WriteLine($"Enter student name {i + 1}:");
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    students.Add(name);
                }
                else
                {
                    Console.WriteLine("Invalid name, please try again.");
                    i--; // Decrement i to repeat this iteration
                }

            }
             Console.WriteLine("\n students entered successfully!");
            Console.WriteLine("---------------==========================----------------------");
            Console.WriteLine("Students List:");
            foreach (var student in students)
            {
                Console.WriteLine($" {student}");
            }
        } 
    }
}

