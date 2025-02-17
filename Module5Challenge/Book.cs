public class Book
{
    // properties of the book title, author, and ISBN
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    // Constructor to initialize the new instance of the Book class
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    // Override the ToString method to provide a string representation of the book
    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}
