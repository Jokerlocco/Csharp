using System;

class PhotoAlbum
{
    protected int amountOfPages;
    
    public PhotoAlbum()
    {
        amountOfPages = 16;
    }
    
    public PhotoAlbum(int pages)
    {
        amountOfPages = pages;
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
    }
}

// ------------------------------

public class PhotoAlbumTest
{
    public static void Main()
    {
        PhotoAlbum album1 = new PhotoAlbum();
        PhotoAlbum album2 = new PhotoAlbum(24);
        BigPhotoAlbum album3 = new BigPhotoAlbum();
        
        Console.WriteLine( "Album 1: "+album1.GetAmountOfPages() );
        Console.WriteLine( "Album 2: "+album2.GetAmountOfPages() );
        Console.WriteLine( "Album 3: "+album3.GetAmountOfPages() );
    }
}
