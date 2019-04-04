//Ivan Lazcano Sindin

// Convert Pascal To C#

// Notes: 
// - Format of "for" not correct yet (:=)
// - Missing last }

using System;
using System.IO;

class Ej
{
    public static void Main(string[] args)
    {
        string name;
        if (args.Length < 1)
        {
            Console.WriteLine("Name?");
            name = Console.ReadLine();
        }
        else
            name = args[0];
            
        if (!File.Exists(name))
            Console.WriteLine("Origin does not exist");
        else
        {
            try
            {
                StreamReader fileRead = new StreamReader(name);
                StreamWriter outFile = 
                    new StreamWriter(name.Replace(".pas", ".cs"));
                string line = fileRead.ReadLine();
                while(line != null)
                {
                    Process(outFile,line.ToLower());
                    line = fileRead.ReadLine();
                }


                fileRead.Close();
                outFile.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Name too long");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
        public static void Process(StreamWriter outFile, string line)
    {
        line = line.Replace("'", "\"");


        if (line.Trim().StartsWith("writeln"))
        {
            line = line.Remove(line.IndexOf("writeln"))
                       +"Console.WriteLine" 
                       +line.Remove(line.IndexOf("writeln"),
                                    "writeln".Length);
        }
        if(line.Contains("write("))
        {
            line = line.Remove(line.IndexOf("write"))
                       + "Console.Write"
                       + line.Remove(line.IndexOf("write"), "write".Length);
        }
        if(line.Contains(" = "))
        {
            line = line.Replace(" = ", " == ");
        }
        if(line.Contains(" := "))
        {
            line = line.Replace(" := ", " = ");
        }
        if(line.Contains("begin"))
        {
            line = line.Replace("begin", "");
        }
        if(line.Contains("end;"))
        {
            line = line.Replace("end;", "}");
        }
        if (line.Contains("end."))
        {
            line = line.Replace("end.", "}");
        }
        if (line.Contains("end"))
        {
            line = line.Replace("end", "}");
        }
        if(line.Contains("program "))
        {
            line = "class " + line.Trim().Split()[1] + "\n{";
            outFile.WriteLine(line.Replace(";",""));
            line = "public static void Main(args[0]) \n{";
        }
        if(line.Contains("readln"))
        {
            line = line.Replace("readln", 
                "x = Convert.ToInt32 (Console.ReadLine");
            line = line.Replace(";", ");");
        }
        if (line.Contains("var"))
            line = line.Replace("var", "");
        if(line.Contains(": integer"))
        {
            line = line.Replace(": integer", "");
            line = line.Insert(line.LastIndexOf(' ')+1, "int ");
        }
        if(line.Contains("if "))
        {
            line = line.Replace("if ", "if (");
            line = line.Replace(" then", ")");
        }
        if(line.Trim().StartsWith("for "))
        {
            
            line = "for ( " + line.Trim().Split()[1]
                                + " = "
                                + line.Trim().Split()[3]
                                + " ; "
                                + line.Trim().Split()[1]
                                + " < "
                                + line.Trim().Split()[5]
                                + " ; "
                                + line.Trim().Split()[1]
                                + "++ )";
        }

        if (line.Contains("(*"))
            line = line.Replace("(*", "/*");
        
        if (line.Contains("*)"))
            line = line.Replace("*)", "*/");

        outFile.WriteLine(line);

    }

}
