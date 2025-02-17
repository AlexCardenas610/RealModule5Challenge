using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    // property to store the name of the library
    public string Name { get; set; }

    // private list to store the books in the library
    private List<Book> Books { get; set; }

    // Constructor to intialize the instance of the library class
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    // Method to add a book to a library
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Added: {book}");
    }

    // Method to remove a book from the library
    public bool RemoveBook(string isbn)
    {
        // find the book with the ISBN
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
        if (bookToRemove != null)
        {
            // removes the book if found
            Books.Remove(bookToRemove);
            Console.WriteLine($"Removed: {bookToRemove}");
            return true;
        }
        // if the book is not found, then it prints this message
        Console.WriteLine("Book not found.");
        return false;
    }

    // method which displays all the available books in the library
    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }

    // method which gets a book from the library using the ISBN
    public Book GetBook(string isbn)
    {
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}