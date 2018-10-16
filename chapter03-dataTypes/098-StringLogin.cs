// Araceli Yáñez Muñoz
// String login

using System;

public class Login
{
    public static void Main()
    {
        string user, pass;
        
        do 
        {
            Console.Write( "User: " );
            user = Console.ReadLine();
            Console.Write( "Password: " );
            pass = Console.ReadLine();
            
            if ((user != "login") || ( pass != "password" ))
                Console.WriteLine( "Access denied!" );
                
        } while ((user != "login") || (pass != "password"));

        Console.WriteLine( "Access granted!" );
    }
}
