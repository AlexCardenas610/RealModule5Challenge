using System;
using System.Collections.Generic;
using System.Linq;

public class Member
{
    // stores the name of the memeber
    public string Name { get; set; }

    // stores the ID of the memebr
    public int ID { get; set; }

    // privte list to store the books borrowed by the member
    private List<Book> BorrowedBooks { get; set; }

    // Constructor to initialize the instance of the member class
    public Member(string name, int id)
    {
        Name = name;
        ID = id;
        BorrowedBooks = new List<Book>();
    }

    // method for the member to borrow a book from the library
    public void BorrowBook(Library library, string isbn)
    {
        // gets the book from the library by ISBN
        Book book = library.GetBook(isbn);
        if (book != null)
        {
            // adds the book(s) to the members borrowed book list
            BorrowedBooks.Add(book);
            library.RemoveBook(isbn);
            Console.WriteLine($"{Name} borrowed: {book}");
        }
        else
        {
            // otherwise, this message outputs the book they selected is not available
            Console.WriteLine("Book not available.");
        }
    }

    // method for the memebers to return a book to the library
    public void ReturnBook(Library library, string isbn)
    {
        // finds the borrowed book in their list by ISBN 
        Book book = BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);
        if (book != null)
        {
            // removes the borrowed book from the members list
            BorrowedBooks.Remove(book);
            library.AddBook(book);
            Console.WriteLine($"{Name} returned: {book}");
        }
        else
        {
            // otherwise, this message displays that the book was not found 
            Console.WriteLine("Book not found in borrowed list.");
        }
    }

    // method to display the members borrowed book list
    public void DisplayBorrowedBooks()
    {
        Console.WriteLine($"{Name}'s Borrowed Books:");
        foreach (var book in BorrowedBooks)
        {
            Console.WriteLine(book);
        }
    }
}