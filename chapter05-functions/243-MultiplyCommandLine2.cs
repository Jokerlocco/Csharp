// Command Line usage 02: 
// reading parameters and returning a value

using System;

public class MultiplyCommandLine2
{
    public static int Main(string[] args)
    {
        if (args.Length == 2)
        {
            try
            {
                Console.WriteLine(Convert.ToInt32(
                    args[0]) * Convert.ToInt32(args[1]));
            }
            catch (Exception)
            {
                return 1;
            }

        }
        else
        {
            Console.WriteLine("Not enough parameters");
            return 1;
        }

        return 0;
    }
}
