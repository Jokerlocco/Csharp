/*

Create a new version (3) of the Document class. You must also have a 
constructor that only receives the title. Test both constructors 
in Main.

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
    {
        this.title = title;
        author = "Unknown";
        pages = 0;
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
        
        Document d2 = new Document("El Quijote");
        Console.WriteLine("Pages (2): {0}",d2.GetPages() );
    }
}
