//Ivan Lazcano Sindin
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


class ReegeexTester
{
    public static bool IsVarCorrecVarName(String s)
    {
        return new Regex(@"\A[A-Fa-f0-9]{1,4}\Z").IsMatch(s);
    }

    public static void Main(string[] args)
    {
        Dictionary<string, bool> test = new Dictionary<string, bool>();
        test.Add("AF", true);
        test.Add("54", true);
        test.Add("99", true);
        test.Add("66AF", true);
        test.Add("99HK", false);
        test.Add("9999", false);
        test.Add("99AF", false);
        test.Add("9D9", false);


        foreach(string s in test.Keys )
        {
            if(IsVarCorrecVarName(s) != test[s])
            {
                Console.WriteLine(s + "->" + IsVarCorrecVarName(s) + "->" + test[s]);
            }
            else
            {
                Console.WriteLine(s + "->ok");
            }
        }

    }
}
