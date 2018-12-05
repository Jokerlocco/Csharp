using System;

public class FunctionWriteInverted1
{
    public static void WriteInverted (string txt)
    {
        for ( int i = txt.Length - 1 ; i >= 0 ; i-- )
        {
            Console.Write( txt[i] );
        }
    }
    
    public static void Main()
    {
        string txt = "hola";
        WriteInverted(txt);
    }
}
