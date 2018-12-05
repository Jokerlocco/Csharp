// Jorge Calzada Asenjo

using System;

public class FunctionWriteInverted2
{
    public static void WriteInverted(string txt)
    {
        string inverted = "";

        for (int i = txt.Length - 1; i >= 0; i--)
        {
            inverted += txt[i];
        }

        Console.WriteLine(inverted);
    }

    public static void Main()
    {
        WriteInverted("Hola");
    }
}
