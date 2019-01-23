/*

Create a new version (2) of the Document class, using the same name for 
the attribute and for the parameter in the constructor.

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
}


public class DocumentTest
{
    public static void Main()
    {
        Document d = new Document("It", "Stephen King", 1100);
        Console.WriteLine("Pages: {0}",d.GetPages() );
    }
}
