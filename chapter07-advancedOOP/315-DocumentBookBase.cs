/*

Extend the Document + Book exercise, using "base" to 
expand from the constructor of the superclass

*/


using System;

public class Document
{
    protected string title;
    protected string author;
    protected int pages;
    
    public Document(string title, 
        string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }
    
    public Document(string title)
        : this (title, "Unknown", 0)
    {
    }
    
    public string GetTitle()
    {
        return title;
    }
    
    public string GetAuthor()
    {
        return author;
    }
    
    public int GetPages()
    {
        return pages;
    }
    
    public void SetTitle(string title)
    {
        this.title = title;
    }
    
    public void SetAuthor(string author)
    {
        this.author = author;
    }
    
    public void SetPages(int pages)
    {
        this.pages = pages;
    }
    
    public void DisplayAuthor()
    {
        Console.WriteLine(this.author);
    }
    
    public void DisplayAuthorAndTitle()
    {
        this.DisplayAuthor();
        Console.WriteLine(this.title);
    }
}

// -----------------------------

public class Book : Document
{
    protected char cover;
    
    public Book(string title,string author, int pages,char cover) 
        : base (title, author, pages)
    {
        this.cover = cover;
    }
    
    public void SetCover(char newCover)
    {
        cover = newCover;
    }
    
    public char GetCover()
    {
        return cover;
    }
}

// -----------------------------

public class DocumentTest
{
    public static void Main()
    {
        Document d = new Document("It", "Stephen King", 1100);
        Console.WriteLine("Pages: {0}",d.GetPages() );
        
        Document d2 = new Document("El Quijote");
        Console.WriteLine("Pages (2): {0}",d2.GetPages() );
        
        Document[] documents = new Document[3];
        for(int i = 0; i < 3; i++)
        {
            documents[i] = new Document(
                "Doc" + (i+1), 
                "author" + (i+1), 
                100);
        }
        
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine(documents[i].GetTitle()
                + ", " + documents[i].GetAuthor());
        }
        
        Book b = new Book("El Quijote", "Cervantes", 2000, 'H');
    }
}
