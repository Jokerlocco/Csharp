// Pide contraseña al usuario si es correcta 
//    "1234" dira contraseña correcta sino incorrecta
// Miguel Isidro Blasco

using System;

public class Password1
{
    public static void Main()
    {
        Console.Write("Password: ");
        int password = Convert.ToInt32(Console.ReadLine());
        
        if(password != 1234)
            Console.Write("Access denied!");
        else
            Console.Write("Access granted!");
    }
}
