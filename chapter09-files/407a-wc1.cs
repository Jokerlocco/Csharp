// Count lines, words, characters
// Manuel Lago

using System.IO;
using System;

class wc
{
    public static void Main(string[] args)
    {
        if ((args.Length > 0) && (File.Exists(args[0])))
        {
            StreamReader file = new StreamReader(args[0]);
            int countL = 0;
            int countW = 0;
            int countC = 0;
            
            string line = file.ReadLine();
            
            while(line != null)
            {
                if(line != null)
                {
                    countL++;
                    
                    line = line.Trim();
                    while(line.Contains("  "))
                    {
                        line = line.Replace("  ", " ");
                    }
                    
                    string[] parts = line.Split();
                    countW += parts.Length;
                    
                    foreach(string s in parts)
                        countC += s.Length;
                }
                
                line = file.ReadLine();
            }
            
            file.Close();
            
            Console.WriteLine("Lines:" + countL);
            Console.WriteLine("Words:" + countW);
            Console.WriteLine("Characters:" + countC);
        }
    }
}
