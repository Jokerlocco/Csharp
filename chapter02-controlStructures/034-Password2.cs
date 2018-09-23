// Gonzalo Arques
// Password (2: while)

using System;

public class Password2
{
    public static void Main ()
    {
        int password;
        
        Console.WriteLine ( "Password: " );
        password = Convert.ToInt32 ( Console.ReadLine () );
        
        while ( password != 1234 )
        {
            Console.WriteLine ( "Wrong password. Enter it again: " );
            password = Convert.ToInt32 ( Console.ReadLine () );
        }
        Console.WriteLine ( "Access granted!" );
    }
}
