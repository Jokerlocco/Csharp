using System;
using System.IO;

class Ej
{
    public static void Main(string[] args)
    {
        Console.WriteLine("File name? ");
        string name = Console.ReadLine();

        StreamReader txtFile = new StreamReader(name);
        StreamWriter htmlFile = new StreamWriter(name + ".html");

        htmlFile.WriteLine("<html>");
        htmlFile.WriteLine("<body>");

        string line = txtFile.ReadLine();
        while (line != null)
        {
            htmlFile.WriteLine("<p>" + line + "</p>");
            line = txtFile.ReadLine();
        }

        htmlFile.WriteLine("</body>");
        htmlFile.WriteLine("</html>");

        htmlFile.Close();
        txtFile.Close();
    }
}
