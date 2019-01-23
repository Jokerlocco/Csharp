/*

Document (11)
Use virtual + override to improve the previous exercise

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
    
    public virtual void ShowData()
    {
        Console.Write("Author = " + author 
            + ", Title = " + title);
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
    
    public override void ShowData()
    {
        base.ShowData();
        Console.Write(", Cover = " + cover);
    }
}

// -----------------------------

public class DocumentTest
{
    public static void Main()
    {
        Document[] documents = new Document[3];
        for(int i = 0; i < 2; i++)
        {
            documents[i] = new Document(
                "Doc" + (i+1), 
                "author" + (i+1), 
                100);
        }
        documents[2] = new Book(
                "Book3", 
                "author3", 
                120, 'H');
        
        for(int i = 0; i < 3; i++)
        {
            documents[i].ShowData();
            Console.WriteLine();
        }
    }
}
