// Jorge Calzada Asenjo
// SQL Analyzer

using System;
using System.IO;

public class SqlAnalyzer
{
    public static void Main(string[] args)
    {
        string path;

        if (args.Length > 0)
        {
            path = args[0];
        }
        else
        {
            Console.Write("Enter the path of the file: ");
            path = Console.ReadLine();
        }

        if (!File.Exists(path))
        {
            Console.WriteLine("The path of the file is not valid");
        }
        else
        {
            try
            {
                StreamReader inputFile = File.OpenText(path);

                StreamWriter outputFile = File.CreateText(path +
                    ".exportado.txt");

                string line;

                do
                {
                    line = inputFile.ReadLine();

                    if (line != null)
                    {
                        line = line.Trim();

                        if (line.ToLower().StartsWith("insert into"))
                        {
                            line = line.Remove(0, 12);

                            outputFile.WriteLine(line.Split()[0]);

                            string stringColumns = line.Substring(
                                line.IndexOf("(") + 1, line.IndexOf(")")
                                - line.IndexOf("(") - 1);

                            line = line.Substring(line.ToLower().IndexOf(
                                "values"));

                            string stringValues = line.Substring(
                                line.IndexOf("(") + 1, line.IndexOf(")")
                                - line.IndexOf("(") - 1);

                            string[] columns = stringColumns.Split(',');

                            string[] values = new string[columns.Length];

                            bool openWord = false;
                            string word = "";
                            int count = 0;

                            for (int i = 0; i < stringValues.Length; i++)
                            {
                                if (stringValues[i] == '\'')
                                {
                                    openWord = !openWord;
                                }
                                else if (!openWord && stringValues[i] ==
                                     ',')
                                {
                                    values[count] = word;
                                    count++;
                                    word = "";
                                }
                                else if (!openWord && stringValues[i] ==
                                     ' ')
                                {

                                }
                                else
                                {
                                    word += stringValues[i];
                                }
                            }

                            values[count] = word;

                            for (int i = 0; i < columns.Length; i++)
                            {
                                outputFile.WriteLine(columns[i].Trim() + ": "
                                + values[i]);
                            }
                        }

                        outputFile.WriteLine();
                    }
                } while (line != null);

                outputFile.Close();
                inputFile.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O error: "+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
        }
    }
}
