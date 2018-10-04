// Login & password, first approach
// Manuel Rojas Henarejos

using System;

public class Login
{
    public static void Main()
    {
        int login, password;
        
        do
        {
            Console.Write("Username: ");
            login = Convert.ToInt32(Console.ReadLine());
            Console.Write("Password: ");
            password = Convert.ToInt32(Console.ReadLine());
            
            if ((login != 1493) || (password != 1234))
                Console.WriteLine("Access denied");
            
        } while ((login != 1493) || (password != 1234));
        
        Console.WriteLine("Access granted");
            
    }
}
