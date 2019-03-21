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
        bool inParagraph = false;
        while (line != null)
        {
            if ((line != "") && (! inParagraph))
            {
                htmlFile.WriteLine("<p>" + line);
                inParagraph = true;
            }
            else if ((line != "") && inParagraph )
            {
                htmlFile.WriteLine("<br />" + line);
                inParagraph = true;
            }
            else if ((line == "") && inParagraph )
            {
                htmlFile.WriteLine("</p>");
                inParagraph = false;
            }    

            line = txtFile.ReadLine();
        }
        
        if ( inParagraph )
        {
            htmlFile.WriteLine("</p>");
        }    

        htmlFile.WriteLine("</body>");
        htmlFile.WriteLine("</html>");

        htmlFile.Close();
        txtFile.Close();
    }
}
