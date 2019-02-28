// Comparing two (big) lists of words (354,985 words vs 235,886)
// Ivan Lazcano

// V1: List<string>
// Time taken: near 07min 30sec on i7 7700HQ (in background)

using System;
using System.IO;
using System.Collections.Generic;

class ComparatorV1
{

    public  static void Main()
    {
        int differences = 0;
        
        Console.WriteLine("Loading...");
        string[] s1 = File.ReadAllLines("words.txt");
        string[] s2 = File.ReadAllLines("words2.txt");

        Console.WriteLine("Populating lists...");
        List<string> l1 = new List<string>(s1);
        List<string> l2 = new List<string>(s2);
        
        Console.WriteLine("Finding differences...");
        DateTime start = DateTime.Now;
        int stringsChecked = 0;
        foreach(string s in l1)
        {
            if (!l2.Contains(s))
                differences++;
            // Progress bar, as it is slow ;-)
            stringsChecked++;
            if (stringsChecked % 10000 == 0)
                Console.Write(stringsChecked+"  ");
        }
        
        Console.WriteLine();
        Console.WriteLine("Differences: " + differences);
        Console.WriteLine("Time taken: " + (DateTime.Now - start));
    }
}
