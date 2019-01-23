/*

Create a new version (4) of the Document class. The constructor with a 
parameter will be based on the constructor with three parameters. 

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


public class DocumentTest
{
    public static void Main()
    {
        Document d = new Document("It", "Stephen King", 1100);
        Console.WriteLine("Pages: {0}",d.GetPages() );
        
        Document d2 = new Document("El Quijote");
        Console.WriteLine("Pages (2): {0}",d2.GetPages() );
    }
}
