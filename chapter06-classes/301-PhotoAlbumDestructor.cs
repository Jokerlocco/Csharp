using System;

class PhotoAlbum
{
    protected int amountOfPages;
    
    public PhotoAlbum()
    {
        amountOfPages = 16;
        Console.WriteLine("Album, "+amountOfPages+" pages");
    }
    
    public PhotoAlbum(int pages)
    {
        amountOfPages = pages;
        Console.WriteLine("Album, "+amountOfPages+" pages");
    }
    
    ~PhotoAlbum()
    {
        Console.WriteLine("Destroying an album");
    }

    public int GetAmountOfPages()
    {
        return amountOfPages;
    }
}

// ------------------------------

class BigPhotoAlbum : PhotoAlbum
{
    public BigPhotoAlbum()
    {
        amountOfPages = 64;
        Console.WriteLine("BigAlbum, "+amountOfPages+" pages");
    }
    
    ~BigPhotoAlbum()
    {
        Console.WriteLine("Destroying an big album");
    }
}

// ------------------------------

public class PhotoAlbumTest
{
    public static void Main()
    {
        // PhotoAlbum album1 = new PhotoAlbum();
        // PhotoAlbum album2 = new PhotoAlbum(24);
        BigPhotoAlbum album3 = new BigPhotoAlbum();
        
        // Console.WriteLine( "Album 1: "+album1.GetAmountOfPages() );
        // Console.WriteLine( "Album 2: "+album2.GetAmountOfPages() );
        // Console.WriteLine( "Album 3: "+album3.GetAmountOfPages() );
    }
}
