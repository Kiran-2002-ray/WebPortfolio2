using System;
using System.Collections.Generic;
using System.Linq;

// Base class for library items demonstrating inheritance
public abstract class LibraryItem
{
    public string Id { get; private set; }
    public string Title { get; private set; }
    public bool IsAvailable { get; set; }

    protected LibraryItem(string id, string title)
    {
        Id = id;
        Title = title;
        IsAvailable = true;
    }
}

// Book class inheriting from LibraryItem
public class Book : LibraryItem
{
    public string Author { get; private set; }
    public int PublicationYear { get; private set; }

    public Book(string id, string title, string author, int publicationYear)
        : base(id, title)
    {
        Author = author;
        PublicationYear = publicationYear;
    }

    public override string ToString()
    {
        return $"Book: {Title} by {Author} ({PublicationYear}) - {(IsAvailable ? "Available" : "Borrowed")}";
    }
}

// User class to manage user information and borrowed books


// Library class to manage books and users
