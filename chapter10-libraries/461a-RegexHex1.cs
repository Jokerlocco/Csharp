//Ivan Lazcano Sindin
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


class ReegeexTester
{
    public static bool IsValidIdentifier(String s)
    {
        return new Regex(@"\A[A-Fa-f0-9]{1,4}\z").IsMatch(s);
    }

    public static void Main(string[] args)
    {
        Dictionary<string, bool> test = new Dictionary<string, bool>();
        test.Add("AF", true);
        test.Add("54", true);
        test.Add("99", true);
        test.Add("66AF", true);
        test.Add("99HK", false);
        test.Add("9999", true);
        test.Add("99AF", true);
        test.Add(".9D9", false);


        foreach(string s in test.Keys )
        {
            if(IsValidIdentifier(s) != test[s])
            {
                Console.WriteLine(s + "->" + 
                    IsValidIdentifier(s) + "->" + test[s]);
            }
            else
            {
                Console.WriteLine(s + "->ok");
            }
        }

    }
}
