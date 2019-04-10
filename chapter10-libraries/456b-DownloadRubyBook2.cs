using System;
using System.IO;
using System.Net;

public class DownloadBokok2
{
    public static void Main()
    {
        Console.Write("Downloading book...");
        WebClient webClient = new WebClient();
        for (int i = 0; i <= 52; i++)
        {
            Console.Write(" " + i);
            webClient.DownloadFile(
                "https://learnrubythehardway.org/book/ex"+
                i + ".html", 
                "ruby"+i.ToString("00")+".html");
        }
    }
}
