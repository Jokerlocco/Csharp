// Jorge Calzada Asenjo

// Convert Pascal To C#

// Notes: 
// - Some minor problems corrected
// - Indentation not correct yet
// - Format of "class" not correct
// - Missing last }

using System;
using System.IO;

class Pascal2CSharp
{
    static void Main(string[] args)
    {
        string pathEnter;

        if (args.Length < 1)
        {
            Console.Write("Enter the path to the file of input: ");
            pathEnter = Console.ReadLine();
        }
        else
        {
            pathEnter = args[0];
        }

        if (!pathEnter.ToLower().EndsWith(".pas"))
        {
            Console.WriteLine("The file does not have Pascal extension (.pas)");
        }
        else
        {
            //try
            {
                StreamReader fileEnter = File.OpenText(pathEnter);
                StreamWriter fileOutput = File.CreateText(
                    pathEnter.Remove(pathEnter.Length - 3) + "cs");
                string line;

                do
                {
                    line = fileEnter.ReadLine();
                    if (line != null)
                    {
                        fileOutput.WriteLine(LineReplace(line));
                    }
                } while (line != null);

                fileOutput.Close();
                fileEnter.Close();
            }
            /*catch (IOException)
            {
                Console.WriteLine("Read/write error");
            }
            catch (Exception e)
            {
                Console.WriteLine("Other error: " + e.Message);
            }*/
        }
    }

    static string LineReplace(string line)
    {
        int spaceWidth = 0;
        while (spaceWidth < line.Length && line[spaceWidth] != ' ')
        {
            spaceWidth++;
        }
        line = line.Trim();

        if (line.ToLower().StartsWith("writeln"))
        {
            line = line.Remove(0, 7);
            line = "Console.WriteLine" + line;
        }
        else if (line.ToLower().StartsWith("write"))
        {
            line = line.Remove(0, 5);
            line = "Console.Write" + line;
        }


        string newLine = "";

        for (int i = 0; i < line.Length; i++)
        {
            if (i > 0 && line[i] == '=' && line[i - 1] != ':')
            {
                newLine += "==";
            }
            else if (i > 0 && line[i] == '=' && line[i - 1] == ':')
            {
                newLine += "=";
            }
            else
            {
                newLine += line[i];
            }
        }

        newLine = newLine.Replace("\'", "\"");

        if (line.ToLower() == "begin")
        {
            newLine = "";
        }
        else if (line.ToLower() == "end;"
            || line.ToLower() == "end."
            || line.ToLower() == "end")
        {
            newLine = "}";
        }
        else if (line.ToLower() == "var")
        {
            newLine = "";
        }

        if (line.ToLower().StartsWith("program"))
        {
            newLine = "class " + line.Substring(line.IndexOf(' ') + 1);
            newLine += "\n    static void Main()\n    {";
        }
        else if (line.ToLower().StartsWith("readln"))
        {
            newLine = line.Substring(
                line.IndexOf("(") + 1,
                line.IndexOf(")") - line.IndexOf("(") - 1)   // Note: corrected
                    + " = Convert.ToInt32 (Console.ReadLine ());";
        }
        else if (line.ToLower().EndsWith("integer;"))
        {
            newLine = "int " + line.Substring(0, line.IndexOf(" ")-1) + ";";  // Note: corrected
        }

        if (line.ToLower().StartsWith("if"))
        {
            newLine = "if(" + line.Substring(
                line.IndexOf(" ") + 1,
                line.LastIndexOf(" ") - line.IndexOf(" ") - 1) + ")"; // Note: corrected
        }
        return new string(' ', spaceWidth) + newLine;
    }
}
