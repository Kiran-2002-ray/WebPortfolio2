using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp1
{
    internal class User
    {
            public string UserId { get; private set; }
            public string Name { get; private set; }
            private List<Book> borrowedBooks; // List to store borrowed books

            public User(string userId, string name)
            {
                UserId = userId;
                Name = name;
                borrowedBooks = new List<Book>();
            }

            public void BorrowBook(Book book)
            {
                if (book.IsAvailable)
                {
                    borrowedBooks.Add(book);
                    book.IsAvailable = false;
                    Console.WriteLine($"{Name} borrowed {book.Title}");
                }
                else
                {
                    Console.WriteLine($"Book {book.Title} is not available");
                }
            }

            public void ReturnBook(Book book)
            {
                if (borrowedBooks.Contains(book))
                {
                    borrowedBooks.Remove(book);
                    book.IsAvailable = true;
                    Console.WriteLine($"{Name} returned {book.Title}");
                }
                else
                {
                    Console.WriteLine($"{Name} does not have {book.Title} borrowed");
                }
            }

            public void ShowBorrowedBooks()
            {
                Console.WriteLine($"\n{Name}'s Borrowed Books:");
                if (borrowedBooks.Count == 0)
                {
                    Console.WriteLine("No books borrowed");
                    return;
                }

                // Using recursion to display books
                DisplayBooksRecursive(borrowedBooks, 0);
            }

            private void DisplayBooksRecursive(List<Book> books, int index)
            {
                // Base case for recursion
                if (index >= books.Count)
                    return;

                Console.WriteLine($"  {index + 1}. {books[index]}");
                // Recursive call
                DisplayBooksRecursive(books, index + 1);
            }
        
    }
}
