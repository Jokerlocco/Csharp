// María González Martínez

using System;

class Book
{
    private string title;
    private string author;
    private string location;
    
    public Book(string newTitle, string newAuthor, string newLocation)
    {
        title = newTitle;
        author = newAuthor;
        location = newLocation;
    }
    
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    
    public string Location
    {
        get { return location; }
        set { location = value; }
    }
}

// ------------------------------------

class BookTest
{
    static void Main(string[] args)
    {
        Book b = new Book("It", "Stephen King", "A1");
    }
}

