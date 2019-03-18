//Ivan Lazcano Sindin
using System;
using System.IO;

class Ej
{
    public static void Main(string[] args)
    {
        string name;
        if (args.Length != 1)
        {
            Console.WriteLine("Name of file?");
            name = Console.ReadLine();

        }
        else
            name = args[0];

        if (File.Exists(name))
        {
            StreamReader basicFile;
            StreamWriter csharpFile;
            try
            {
                basicFile = new StreamReader(name);

                csharpFile = new StreamWriter(name.Split('.')[0] + ".cs");
            }
            catch (Exception)
            {
                Console.WriteLine("File error");
                return;
            }
            csharpFile.WriteLine("using System;");
            csharpFile.WriteLine("class EJ");
            csharpFile.WriteLine("{");
            csharpFile.WriteLine("\tpublic static void Main(string[] args)\n\t{");

            string line = "";
            line = basicFile.ReadLine();
            while (line != null)
            {
                if(line.Length > 0)
                    switch (line.ToUpper().Split()[1])
                    {
                        case "PRINT":
                            csharpFile.Write("\t\t");

                            csharpFile.WriteLine("Console.WriteLine("
                                     + line.Substring(line.ToUpper()
                                      .IndexOf("PRINT") + "print".Length) + " );");
                            break;

                        case "INPUT":
                            csharpFile.Write("\t\t");
                            csharpFile.WriteLine("int" +
                                     line.Substring(line.ToUpper()
                                    .IndexOf("INPUT") + "INPUT".Length) +
                                     " = Convert.ToInt32(Console.ReadLine());");
                            break;
                    }
                    line = basicFile.ReadLine();
            }

            csharpFile.WriteLine("\t}\n}");

            csharpFile.Close();
            basicFile.Close();
        }
        else
            Console.WriteLine("Wrong name");
    }
}
