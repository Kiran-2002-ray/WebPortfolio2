using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp1
{
    internal class Library
    {
            private Dictionary<string, Book> books; // Dictionary to store books by ID
            private Dictionary<string, User> users; // Dictionary to store users by ID
            private string[] libraryRules; // Array to store library rules

            public Library()
            {
                books = new Dictionary<string, Book>();
                users = new Dictionary<string, User>();
                libraryRules = new string[]
                {
            "Maximum 3 books per user",
            "Loan period: 14 days",
            "Late return penalty: $1/day"
                };
            }

            public void AddBook(Book book)
            {
                if (!books.ContainsKey(book.Id))
                {
                    books.Add(book.Id, book);
                    Console.WriteLine($"Added book: {book.Title}");
                }
                else
                {
                    Console.WriteLine($"Book with ID {book.Id} already exists");
                }
            }

            public void AddUser(User user)
            {
                if (!users.ContainsKey(user.UserId))
                {
                    users.Add(user.UserId, user);
                    Console.WriteLine($"Added user: {user.Name}");
                }
                else
                {
                    Console.WriteLine($"User with ID {user.UserId} already exists");
                }
            }

            public void BorrowBook(string userId, string bookId)
            {
                if (users.ContainsKey(userId) && books.ContainsKey(bookId))
                {
                    users[userId].BorrowBook(books[bookId]);
                }
                else
                {
                    Console.WriteLine("Invalid user ID or book ID");
                }
            }

            public void ReturnBook(string userId, string bookId)
            {
                if (users.ContainsKey(userId) && books.ContainsKey(bookId))
                {
                    users[userId].ReturnBook(books[bookId]);
                }
                else
                {
                    Console.WriteLine("Invalid user ID or book ID");
                }
            }

            public void DisplayLibraryInfo()
            {
                Console.WriteLine("\nLibrary Information:");
                Console.WriteLine("Library Rules:");
                foreach (var rule in libraryRules) // Using array
                {
                    Console.WriteLine($"  - {rule}");
                }

                Console.WriteLine("\nAvailable Books:");
                var availableBooks = books.Values.Where(b => b.IsAvailable).ToList();
                if (availableBooks.Count == 0)
                {
                    Console.WriteLine("No books available");
                    return;
                }

                // Using recursion to display available books
                DisplayBooksRecursive(availableBooks, 0);
            }

            private void DisplayBooksRecursive(List<Book> books, int index)
            {
                if (index >= books.Count)
                    return;

                Console.WriteLine($"  {index + 1}. {books[index]}");
                DisplayBooksRecursive(books, index + 1);
            }
    }
}
