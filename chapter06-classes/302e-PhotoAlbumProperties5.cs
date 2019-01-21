using System;

class PhotoAlbum
{
    public int AmountOfPages { get; }
    
    public PhotoAlbum()
    {
        AmountOfPages = 16;
    }
    
    public PhotoAlbum(int pages)
    {
        AmountOfPages = pages;
    }

    
}

// ------------------------------

class BigPhotoAlbum : PhotoAlbum
{
    public BigPhotoAlbum()
    {
        AmountOfPages = 64;
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
        
        Console.WriteLine( "Album 1: "+album1.AmountOfPages );
        Console.WriteLine( "Album 2: "+album2.AmountOfPages );
        Console.WriteLine( "Album 3: "+album3.AmountOfPages );
        
        album1.AmountOfPages = 40;
        Console.WriteLine( "Album 1: "+album1.AmountOfPages );
    }
}
