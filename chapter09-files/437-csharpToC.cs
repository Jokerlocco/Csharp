using System;
using System.IO;

class CsharpToC
{
    public static void Main(string[] args)
    {
        string name;
        if (args.Length == 1)
        {
            name = args[0];
        }
        else
        {
            Console.Write("Enter the C# file name: ");
            name = Console.ReadLine();
        }

        if (!File.Exists(name))
        {
            Console.WriteLine("File not found");
            return;
        }

        if (!name.EndsWith(".cs"))
        {
            Console.WriteLine("Source must be a C# file");
            return;
        }

        StreamReader source;
        StreamWriter destination;
        try
        {
            source = new StreamReader(name);
            destination = new StreamWriter(name.Substring(0,
                name.Length - 1));

            string line = source.ReadLine();
            while (line != null)
            {
                ProcessAndDump(line, destination);
                line = source.ReadLine();
            }

            destination.Close();
            source.Close();
            Console.WriteLine("Conversion finished");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        catch (IOException e)
        {
            Console.WriteLine("I/O error: " + e.Message);
        }
        //catch (Exception e)
        {
            //Console.WriteLine("Error:" + e.Message);
        }
    }

    static void ProcessAndDump(string line, StreamWriter file)
    {

        // "using" must not be present
        if (line.StartsWith("using "))
            return;

        // "class" must not be there, too
        if ((line.StartsWith("class "))
             || (line.StartsWith("public class ")))
            return;

        // { and } for the class
        if ((line.TrimEnd() == "{")
             || (line.TrimEnd() == "}"))
            return;

        // Comments
        if (line.Contains("//"))
        {
            line = line.Replace("//", "/*") + " */";
        }

        // Untab
        if (line.StartsWith("    "))
            line = line.Substring(4);

        // Console.Write
        if (line.Contains("Console.Write("))
        {
            line = line.Replace("Console.Write(", "printf(");
            line = line.Replace("{0}", "%d");
            line = line.Replace("{1}", "%d");
        }

        // Console.WriteLine
        if (line.Contains("Console.WriteLine("))
        {
            line = line.Replace("Console.WriteLine(", "printf(");
            int posOfLastQuote = line.LastIndexOf("\"");
            line.Insert(posOfLastQuote - 1, "\n");
            line = line.Replace("{0}", "%d");
            line = line.Replace("{1}", "%d");
        }

        // Console.ReadLine
        if (line.Contains("Console.ReadLine()"))
        {
            // Let's extract the variable name
            string[] parts = line.Trim().Split();
            string variableName = "";
            if (parts[0] == "int")
                variableName = parts[1];
            else
                variableName = parts[0];
            int spaces = 0;
            while (line[spaces] == ' ')
                spaces++;
            line = new string(' ', spaces)
                + "int "+ variableName + "; scanf(\"%d\",&"
                + variableName+");";
        }

        // for
        if ((line.Trim().StartsWith("for ("))
            || (line.Trim().StartsWith("for(")))
        {
            // Let's remove "int"
            if (line.Contains("(int "))
                line = line.Replace("(int ", "(");
            // Let's extract the variable name
            int startOfVariable = line.IndexOf("(")+1;
            int endOfVariable = line.IndexOf("=");
            string variableName = line.Substring(startOfVariable,
                endOfVariable - startOfVariable).Trim();
            // And make the new command
            int spaces = 0;
            while (line[spaces] == ' ')
                spaces++;
            line = new string(' ', spaces)
                + "int " + variableName + "; " + line.TrimStart();
        }
        
        // main
        if (line.Contains("static void Main"))
        {
            file.WriteLine("#include <stdio.h>");
            line = "int main()";
        }

        // Finally, let's dump the result
        file.WriteLine(line);

    }
}
