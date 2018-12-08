// Command Line usage 01: reading parameters

using System;

public class CommandLine01
{    
    public static void Main( string[] args )
    {
        if ( args.Length == 2 )
        {
            Console.WriteLine(
                Convert.ToInt32(args[0]) * 
                Convert.ToInt32(args[1]));
        }
        else
        {
            Console.WriteLine("Not enough parameters");
        }
    }
    
}
