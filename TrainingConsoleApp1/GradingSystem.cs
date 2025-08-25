using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp1
{
    internal class GradingSystem
    {
        public void GradingStudents()
        {
            Dictionary<string, (int Score, string Grade)> studentGrades = new Dictionary<string, (int, string)>();
            bool continueInput = true;

            while (continueInput)
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                int score;
                while (true)
                {
                    Console.Write("Enter score (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
                        break;
                    else
                        Console.WriteLine("Invalid score! Please enter a number between 0 and 100.");
                }

                string grade = AssignGrade(score);
                studentGrades[name] = (score, grade);

                Console.WriteLine($"{name} scored {score} and got grade: {grade}");

                Console.Write("Do you want to enter another student? (y/n): ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "y")
                    continueInput = false;
            }

            Console.WriteLine("\n===== Final Grade Report =====");
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key}: Score = {student.Value.Score}, Grade = {student.Value.Grade}");
            }
        }

        static string AssignGrade(int score)
        {
            if (score >= 90)
                return "A+";
            else if (score >= 80)
                return "A";
            else if (score >= 70)
                return "B";
            else if (score >= 60)
                return "C";
            else if (score >= 50)
                return "D";
            else
                return "F";
        }


    }
}
