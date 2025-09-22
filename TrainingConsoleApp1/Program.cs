using System.Reflection;

namespace TrainingConsoleApp1
{
    class Day1
    {
        static void Main(string[] args)
        {
            try
            {

                RockPaperScissor.RockpaperScissorGame();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Printer printer = new Printer();
                printer.PrintBookDetails(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Classic"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Library library = new Library();

            Console.WriteLine("Enter a category to search (e.g., Programming, Fantasy, Science Fiction):");
            string category = Console.ReadLine();

            library.SearchBooksByCategory(category);

        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author, string category, bool isAvailable = true)
        {
            Title = title;
            Author = author;
            Category = category;
            IsAvailable = isAvailable;
        }
    }

    // Library class
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>
            {
                new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy"),
                new Book("1984", "George Orwell", "Dystopian"),
                new Book("C# in Depth", "Jon Skeet", "Programming"),
                new Book("The Pragmatic Programmer", "Andy Hunt", "Programming"),
                new Book("Dune", "Frank Herbert", "Science Fiction"),
                new Book("Foundation", "Isaac Asimov", "Science Fiction"),
                new Book("Clean Code", "Robert C. Martin", "Programming")
            };
        }

        // 🔎 Search by category using LINQ
        public void SearchBooksByCategory(string category)
        {
            var result = books
                         .Where(b => b.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                         .ToList();

            if (result.Any())
            {
                Console.WriteLine($"\nBooks in '{category}' category:");
                foreach (var book in result)
                {
                    Console.WriteLine($"📖 {book.Title} by {book.Author} ({(book.IsAvailable ? "Available" : "Not Available")})");
                }
            }
            else
            {
                Console.WriteLine($"\nNo books found in '{category}' category.");
            }

            // Example usage
            Library library = new Library();

                // Create books
                Book book1 = new Book("B001", "The Great Gatsby", "F. Scott Fitzgerald", 1925);
                Book book2 = new Book("B002", "1984", "George Orwell", 1949);

                // Create users
                User user1 = new User("U001", "Alice Smith");

                // Add to library
                library.AddBook(book1);
                library.AddBook(book2);
                library.AddUser(user1);

                // Test borrowing and returning
                library.BorrowBook("U001", "B001");
                user1.ShowBorrowedBooks();
                library.DisplayLibraryInfo();

                library.ReturnBook("U001", "B001");
                library.DisplayLibraryInfo();



            Calculator calculator = new Calculator();
            calculator.CalculatorOperations();

            GradingSystem gradingSystem = new GradingSystem();
            gradingSystem.GradingStudents();

            NumberGuessGame numbergame = new NumberGuessGame();
            numbergame.Game();

            DataDictionary search = new DataDictionary();
            search.SearchCapital();

            StudentList studentList = new StudentList();
            studentList.ListOfStudents();


            ProductManagementSystem productManagement = new ProductManagementSystem();
            productManagement.ProductManager();

            // Create an object of FibonacciCalculator
            FibonacciCalculator fibCalc = new FibonacciCalculator();

            Console.WriteLine("Enter how many terms of Fibonacci series you want:");
            int terms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nFibonacci Series:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(fibCalc.Fibonacci(i) + " "); // Call method using object
            }
            Console.WriteLine();

            Console.WriteLine("Welcome to C# Day 1");
            collectUserInfo();
            helloWithTwist();
            SimpleCalculator();
            CalculatorWithIfElse();
            AgeCalculator();
            Console.WriteLine("Complete Day1 task");


            Console.WriteLine("Welcome to C# Day 2");
            ConditionalStatementIfelse();
            SwitchStatements();
            loopFor();
            loopWhile();
            LoopDoWhile();
            LoopForeach();
            ArraysFunc();
            calculatorUsingFunc();
            GradeChecker();
            multiplicationTable();
            SimpleToDoList();
            scopeCsharp();
            RunFactorialProgram();
            RunGradingSystem();
            StartGame();




            Console.WriteLine("Complete Day2 task");

        }

        static void collectUserInfo()
        {
            // STEP 1: Input Section
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your math score: ");
            float math_score = float.Parse(Console.ReadLine());

            Console.Write("Enter your grade: ");
            char grade = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after key input

            Console.Write("Did you pass? (true/false): ");
            bool isPassed = bool.Parse(Console.ReadLine());

            // STEP 2: Show Raw Input (Original Values)
            Console.WriteLine("\n--- Original Input ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Math Score: " + math_score);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Passed: " + isPassed);

            // STEP 3: Apply Changes
            math_score += 10; // Add 10 to score

            // STEP 4: Display Derived Info (After Changes)
            Console.WriteLine("\n--- Processed Output ---");

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

            Console.WriteLine("Updated Math Score (+10): " + math_score);

            if (math_score >= 50)
            {
                Console.WriteLine("You have passed the math exam.");
            }
            else
            {
                Console.WriteLine("You have failed the math exam.");
            }

            Console.WriteLine("Final Grade: " + grade);
            Console.WriteLine("Final Status (Passed overall): " + isPassed);

            Console.WriteLine("\nThank you, " + name + "! Program complete.");
            Console.WriteLine("......");

        }
        static void helloWithTwist()
        {
            //HelloInfo world with a twist
            Console.Write("What is your name:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}, welcome to the world of C#!");
        }
        static void SimpleCalculator()
        {
            // simple calculator:------

            Console.WriteLine("Welcome to the Simple Calculator!");
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator (+, -, *, /): ");

            char operation = Console.ReadKey().KeyChar;
            // Handle the operator input
            Console.WriteLine(); // Move to the next line after operator input
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    break;
            }
            // End of the calculator
            Console.WriteLine("Thank you for using the Simple Calculator!");
        }
        static void CalculatorWithIfElse()
        {

            Console.WriteLine("Calculator usig If/Else loop");
            Console.WriteLine("Enter first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(number1);
            Console.WriteLine("Enter Second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(number2);

            Console.WriteLine("Choose the operations ( + , - , * , / , % )");
            String op = Console.ReadLine();
            //Console.WriteLine(op);
            Console.WriteLine();

            double Result = 0;
            if (op == "+")
            {
                Result = number1 + number2;
                Console.WriteLine("Sum of the two number:" + Result);
            }
            else if (op == "-")
            {
                Result = number1 - number2;
                Console.WriteLine("Subtraction of the two number" + Result);
            }
            else if (op == "*")
            {
                Result = number1 * number2;
                Console.WriteLine("Multiplication of the two number" + Result);
            }
            else if (op == "/")
            {
                if (number1 > number2)
                {
                    Result = number1 / number2;
                    Console.WriteLine("Division of the two number" + Result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }

            }
            else if (op == "%")
            {
                Result = number1 % number2;
                Console.WriteLine("Modulus of the two number" + Result);
            }
            else
            {
                Console.WriteLine("Invalid operators");
            }
        }
        static void AgeCalculator()
        {
            Console.WriteLine("Enter your birth year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            if (birthYear > currentYear)
            {
                Console.WriteLine("Invalid input. Birth year cannot be in the future.");
                return;
            }

            else
            {
                int Age = currentYear - birthYear;
                Console.WriteLine("You are " + Age + " years old");
                Console.WriteLine("User is :");
                if (Age < 12)
                {
                    Console.WriteLine("Child");
                }
                else if (Age <= 18)
                {
                    Console.WriteLine("Teenage");
                }
                else
                {
                    Console.WriteLine("Adult");
                }
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }
        static void ConditionalStatementIfelse()
        {
            int score;
            Console.WriteLine("Enter the Science Score out of 100: ");
            //int score = Convert.ToInt32(Console.ReadLine());
            bool isValid = int.TryParse(Console.ReadLine(), out score);
            if (!isValid || score <= 0 || score >= 100)
            {
                Console.WriteLine("Invalid Input! Please enter a valid number between 0 and 100 ");
                return;// Exit the function early if input is invalid
            }


            if (score >= 91)
            {
                Console.WriteLine("Grade A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D or below");
            }
            Console.WriteLine("-----------------------------===================----------------------------------------");
        }
        static void SwitchStatements()
        {
            Console.WriteLine("Enter your Grade ( A - D ): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || input.Length != 1)
            {
                Console.WriteLine("Invalid input. Please enter a single character (A-D)");
                return;
            }
            char Grade = Char.ToUpper(input[0]);
            Console.WriteLine();


            //char Grade = Console.ReadKey().KeyChar; //is a simple way to get exactly one character without requiring the user to press Enter.
            switch (Grade)
            {
                case 'A':
                    Console.WriteLine("Execelent!");
                    break;
                case 'B':
                    Console.WriteLine("Good Job!");
                    break;
                case 'C':
                    Console.WriteLine("You Passed");
                    break;
                case 'D':
                    Console.WriteLine("Passed with minimum grades");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }

        }
        static void loopFor()
        {
            Console.WriteLine("Rollno. for class A:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Roll No. " + i + " from " + num + " Students");
                Console.WriteLine($"Roll No: {i} of Total: {num}");
            }
        }
        static void loopWhile()
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number <= 30)
            {
                Console.WriteLine("Number is " + number);
                number++;
            }
        }
        static void LoopDoWhile()
        {
            int a = 1;
            do
            {
                Console.WriteLine(" a = " + a);
                a++;
            } while (a <= 3);
        }
        static void LoopForeach()
        {
            string[] colors = { "Red", "Green", "Blue" };
            Console.WriteLine("Color List:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Enter fruit names separated by commas (e.g. Apple, Mango, Banana):");
            string input = Console.ReadLine();

            // Split the input into an array    
            string[] fruits = input.Split(',');

            Console.WriteLine("Fruits list:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit.Trim());
            }
        }
        static void ArraysFunc()
        {
            string[] states = new string[5];
            states[0] = "Haryana";
            states[1] = "Punjab";
            states[2] = "Uttrakhand";
            states[3] = "Himanchal";
            states[4] = "Rajasthan";

            Console.WriteLine("The second state:" + states[1]);
            Console.WriteLine("The fourth state:" + states[3]);

            string[] tasks = new string[5];
            Console.WriteLine("Enter 5 tasks:");

            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"Enter task {i + 1}: ");
                tasks[i] = Console.ReadLine();
            }
            //task entered
            Console.WriteLine("Today's task List:");
            foreach (string task in tasks)
            {
                Console.WriteLine("-" + task);
            }
        }
        static void calculatorUsingFunc()
        {
            int result = addNum(5, 6);
            Console.WriteLine(result);
            static int addNum(int p, int q)
            {
                return p + q;
            }
            int result0 = addNum(4, 9);
            int result1 = subNum(10, 5);
            Console.WriteLine(result1);
            Console.WriteLine(result0);
            static int subNum(int p, int q)
            {
                return p - q;
            }
            int result2 = mulNum(5, 6);
            Console.WriteLine(result2);
            static int mulNum(int p, int q)
            {
                return p * q;
            }
            int result3 = divNum(60, 6);
            Console.WriteLine(result3);
            static int divNum(int p, int q)
            {
                return p / q;
            }
            int result4 = modNum(50, 6);
            Console.WriteLine(result4);
            static int modNum(int p, int q)
            {
                return p % q;
            }
        }
        static int globalCounter = 0; // Global variable
        static void GradeChecker()
        {
            Console.WriteLine("Enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number);
            if (number >= 90 && number <= 100)
            {
                Console.WriteLine("Grade A");
            }
            else if (number >= 80 && number < 90)
            {
                Console.WriteLine("Grade B");
            }
            else if (number >= 70 && number < 80)
            {
                Console.WriteLine("Grade C");
            }
            else if (number >= 60 && number < 70)
            {
                Console.WriteLine("Grade D");
            }
            else if (number >= 50 && number < 60)
            {
                Console.WriteLine("Grade E");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        static void multiplicationTable()
        {
            Console.WriteLine("Enter a number to generate its multiplication table:");
            int numberr = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numberr} * {i} = {numberr * i} ");
            }
        }

        //static void SimpleToDoList()
        //{
        //    List<string> tasks = new List<string>();
        //    bool exit = false;

        //    while (!exit)
        //    {
        //        Console.WriteLine("\n===================================== Simple To-Do List ================================================");
        //        Console.WriteLine("1. Add a new task");
        //        Console.WriteLine("2. View all tasks");
        //        Console.WriteLine("3. Mark a task as completed");
        //        Console.WriteLine("4. Delete a task");
        //        Console.WriteLine("5. Exit");
        //        Console.Write("Enter your choice (1-5): ");
        //        string choice = Console.ReadLine();

        //        switch (choice)
        //        {
        //            case "1":
        //                Console.Write("Enter task description: ");
        //                string task = Console.ReadLine();
        //                tasks.Add("[✘] " + task);
        //                Console.WriteLine("✅ Task added.");
        //                break;

        //            case "2":
        //                Console.WriteLine("\n📋 Your Tasks:");
        //                if (tasks.Count == 0)
        //                {
        //                    Console.WriteLine("No tasks available.");
        //                }
        //                else
        //                {
        //                    for (int i = 0; i < tasks.Count; i++)
        //                    {
        //                        Console.WriteLine($"{i + 1}. {tasks[i]}");
        //                    }
        //                }
        //                break;

        //            case "3":
        //                Console.Write("Enter task number to mark as completed: ");
        //                if (int.TryParse(Console.ReadLine(), out int completeIndex) &&
        //                    completeIndex >= 1 && completeIndex <= tasks.Count)
        //                {
        //                    tasks[completeIndex - 1] = tasks[completeIndex - 1].Replace("[✘]", "[✔]");
        //                    Console.WriteLine("✅ Task marked as completed.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("❌ Invalid task number.");
        //                }
        //                break;

        //            case "4":
        //                Console.Write("Enter task number to delete: ");
        //                if (int.TryParse(Console.ReadLine(), out int deleteIndex) &&
        //                    deleteIndex >= 1 && deleteIndex <= tasks.Count)
        //                {
        //                    tasks.RemoveAt(deleteIndex - 1);
        //                    Console.WriteLine("🗑️ Task deleted.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("❌ Invalid task number.");
        //                }
        //                break;

        //            case "5":
        //                Console.WriteLine("👋 Exiting the application. Goodbye!");
        //                exit = true;
        //                break;

        //            default:
        //                Console.WriteLine("❗ Invalid choice. Please enter a number between 1 and 5.");
        //                break;
        //        }
        //    }
        //}

        static void SimpleToDoList()
        {
            List<string> tasks = new List<string>();
            List<bool> completed = new List<bool>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== Simple To-Do List =====");
                Console.WriteLine("1. Add a new task");
                Console.WriteLine("2. View all tasks");
                Console.WriteLine("3. Mark a task as completed");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter task description: ");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        completed.Add(false); // Initially not completed
                        Console.WriteLine("Task added.");
                        break;

                    case "2":
                        Console.WriteLine("\n Your Tasks:");
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks available.");
                        }
                        else
                        {
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                string status = completed[i] ? "[✓]" : "[✘]";
                                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
                            }
                        }
                        break;

                    case "3":
                        Console.Write("Enter task number to mark as completed: ");
                        if (int.TryParse(Console.ReadLine(), out int completeIndex) &&
                            completeIndex >= 1 && completeIndex <= tasks.Count)
                        {
                            completed[completeIndex - 1] = true;
                            Console.WriteLine(" Task marked as completed.");
                        }
                        else
                        {
                            Console.WriteLine(" Invalid task number.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter task number to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int deleteIndex) &&
                            deleteIndex >= 1 && deleteIndex <= tasks.Count)
                        {
                            tasks.RemoveAt(deleteIndex - 1);
                            completed.RemoveAt(deleteIndex - 1);
                            Console.WriteLine(" Task deleted.");
                        }
                        else
                        {
                            Console.WriteLine(" Invalid task number.");
                        }
                        break;

                    case "5":
                        Console.WriteLine(" Exiting the application. Goodbye!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("❗ Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }
        static void scopeCsharp()
        {
            Display();
            Another();

            static void Display()
            {
                int localCounter = 0; // Local variable
                Console.WriteLine("Global Counter: " + globalCounter);
                Console.WriteLine("Local Counter: " + localCounter);
            }

            static void Another()
            {
                Console.WriteLine("glocalCounter: " + globalCounter);
                // Console.WriteLine("Local Counter: " + localCounter); // This will cause an error because localCounter is not accessible here
            }
        }

        static void RunFactorialProgram()
        {
            // 🔹 1. Hardcoded factorial of 5 (basic)
            int fact = Factorial(5);
            Console.WriteLine("Factorial of 5 is: " + fact);

            // 🔹 2. Factorial using user input
            Console.WriteLine("\nEnter a number to calculate its factorial:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput <= 0)
            {
                Console.WriteLine("❌ Please enter a positive integer greater than 0.");
            }
            else
            {
                int userFact = FactRecursion(userInput);
                Console.WriteLine($"✅ Factorial of {userInput} is: {userFact}");
            }

            // 🔹 3. Another hardcoded factorial with trace
            Console.WriteLine("\n-------------------------------------------------------");
            Console.WriteLine("Factorial of 6 (with trace):");
            FactRecursion(6);
        }

        static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
        static int FactRecursion(int numb)
        {
            if( numb==1)
            {
                Console.WriteLine("Base case reached with numb = 1");
                return 1;
            }

            int Result = numb * FactRecursion(numb - 1);
            Console.WriteLine($"FactRecursion({numb}) = {numb} * FactRecursion({numb - 1}) = {Result}  ");
            return Result;
        }
        static void RunGradingSystem()
        {
            Console.WriteLine("=====================::::::::::::::::::::::::::::::++++++++++++++++:::::::::::::::::::::::::::::======================");
            Console.WriteLine("Welcome to the Grading System!");
            Console.WriteLine("Enter your score (0-100): ");
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out int score);
            if(!isValid || score<0 || score > 100)
            {
                Console.WriteLine("Invalid input! Please enter a number between 0 and 100.");
                return; 
            }
            char grade = CalculateGrade(score);
            Console.WriteLine($"Score : {score} ->  Grade : {grade} ");
        }
        static char CalculateGrade(int score)
        {
            if (score >= 90)
                return 'A';
            else if (score >= 80)
                return 'B';
            else if (score >= 70)
                return 'C';
            else if (score >= 60)
                return 'D';
            else
                return 'F';
        }

        static void StartGame()
        {
            Random random = new Random();
            int target = random.Next(1, 101); // Random number between 1 and 100
            int maxAttempts = 5;

            Console.WriteLine("🎮 Welcome to the Number Guessing Game!");
            Console.WriteLine("Guess the number between 1 and 100. You have 5 chances.\n");
            
            for(int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                int guess = GetUserGuess();

                if (CheckWin(guess, target))
                {
                    return;
                }
                GiveHint(guess, target);
                Console.WriteLine($" ! Attempts left: {maxAttempts - attempt}\n");

            }
        }
        static int GetUserGuess()
        {
            while (true)
            {
                Console.WriteLine("Enter your guess: ");
                string input = Console.ReadLine();

                if(int.TryParse(input, out  int guess))
                {
                    if(guess>=1 && guess <=100)
                    {
                        return guess;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 1 and 100");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Invalid input. Enter a number only.");
                }
            }
        }
        static bool CheckWin(int guess, int target)
        {
            if (guess == target)
            {
                Console.WriteLine(" Correct! You guessed the number!");
                return true;
            }
            else 
                return false;
        }
        static void GiveHint(int guess, int target)
        {
            if(guess < target)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Too high");
            }
        }








    }
}


//using System;
//    namespace TrainingConsoleApp1
//    {
//internal class Program
//{
//static void Main(string[] args)
//{
//    Console.WriteLine("Hello, World!");
//    Console.Write("Hello C#          /");
//    Console.WriteLine("    Hello .NET 8");

//    Console.Write("heyyyyy");
//    Console.Write(" ");
//    Console.WriteLine("Congratulation");

//    Console.WriteLine("hiii");
//    Console.Write("heyyyyy");
//    Console.ReadLine();
//}
//}
//class Day1
//{
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to C# Day 1");
//            Console.WriteLine("Enter your name:");
//            string name = Console.ReadLine();
//            Console.Write("Enter your age: ");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter your math score: ");
//            float math_score = float.Parse(Console.ReadLine());
//            Console.WriteLine("Enter your grade: ");
//            char grade = Console.ReadKey().KeyChar;
//        Console.WriteLine(); // To move to the next line after reading the grade
//        Console.Write("Did you pass? (true/false): ");
//            bool isPassed = bool.Parse(Console.ReadLine());
//            // Additional code can be added here for further functionality
//            Console.WriteLine("Hello " + name + ", welcome to C# training day1");
//            Console.WriteLine("Your age is : " + age);
//            Console.WriteLine("Your math score is: " + math_score);
//            Console.WriteLine("Your grade is " + grade);
//            Console.WriteLine("Did you pass?" +isPassed);
//        // Displaying the student information
//        math_score += 10;

//        Console.WriteLine("Student Info:");
//            Console.WriteLine("Name:" + name);
//            Console.WriteLine("age:" + age);
//        if(age < 18)
//        {
//            Console.WriteLine("You are a minor.");
//        }
//        else
//        {
//            Console.WriteLine("You are an adult.");
//        }
//         if (math_score >= 50)
//            {
//                Console.WriteLine("You have passed the math exam.");
//            }
//            else
//            {
//                Console.WriteLine("You have failed the math exam.");
//            Console.WriteLine("Math's Score:" + math_score);
//            Console.WriteLine("Grade:" + grade);
//            Console.WriteLine("status" + isPassed);
//        }
//}
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Welcome to C# Day 1!");
//    }
//}
//namespace System;
//class Day1
//{
//    string name = "kiran";
//    int age = 22;
//    float math_score = 99.5f;
//    char grade = 'A';
//    bool isPassed = true;
//    static void main(string[] args)
//    {
//        Console.WriteLine("Welcome to C# Day 1");
//        Console.WriteLine("Enter your name:");
//    }
//}
