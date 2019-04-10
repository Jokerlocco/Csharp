//Kevin Marín Romero

using System;
using System.IO;
using System.Net;

public class DownloadWeb
{
    public static void Download(Stream connection,int i)
    {
        StreamReader reader = new StreamReader(connection);
        StreamWriter file = new StreamWriter("Challenge" + i + ".html");

        string line;

        do
        {
            line = reader.ReadLine();

            if (line != null)
            {
                file.WriteLine(line);
            }
        } while (line != null);

        file.Close();
        reader.Close();
    }

    static void Main(string[] args)
    {
        
        WebClient client = new WebClient();
        Stream connection;
        for (int i = 100; i <= 110; i++)
        {
            connection = client.OpenRead(
                "https://www.aceptaelreto.com/problem/statement.php?id=" 
                + i);
            Download(connection,i);
            Console.WriteLine("Challenge " + i + " downloaded");
        }
        Console.WriteLine("Done!");
    }
}
