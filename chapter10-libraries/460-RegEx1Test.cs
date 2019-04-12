using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Regex1
{
    public static void Main()
    {
        bool debugging = true;
        if (debugging) TestIsValidIdentifier();
        
        Console.WriteLine("Enter the identifier: ");
        string dato = Console.ReadLine();

        Console.WriteLine(IsValidIdentifier(dato));
    }

    public static bool IsValidIdentifier(string s)
    {
        Regex r = new Regex(@"\A[a-zA-Z][A-Za-z0-9]*\z");
        return r.IsMatch(s);
    }
    
    public static void TestIsValidIdentifier()
    {
        Dictionary<string,bool> tests = new Dictionary<string,bool>();
        
        tests.Add("hola", true);
        tests.Add("hola1", true);
        tests.Add("Hola12", true);
        tests.Add("H", true);
        
        tests.Add("1hola", false);
        tests.Add("ho-la", false);
        tests.Add("Hola ", false);
        
        foreach( KeyValuePair<string,bool> test in tests)
        {
            string data = test.Key;
            bool expectedAnswer = test.Value;
            bool realAnswer = IsValidIdentifier(data);
            
            if (realAnswer == expectedAnswer)
                Console.Write("OK ");
            else
                Console.Write("Fail:" + data+" ");
        }
        
    }
}
