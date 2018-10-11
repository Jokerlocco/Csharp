
// Marks, switch (2)
using System;

public class Marks2
{
    public static void Main()
    {
        Console.Write("Enter your mark: ");
        int mark = Convert.ToInt32( Console.ReadLine());

        switch ( mark )
        {
            case 0: 
            case 1: 
            case 2: 
            case 3: 
            case 4: Console.WriteLine("Suspenso"); break;
            
            case 5: Console.WriteLine("Aprobado");  break;
            
            case 6: Console.WriteLine("Bien");  break;
            
            case 7: 
            case 8: Console.WriteLine("Notable");   break;
            
            case 9: 
            case 10: Console.WriteLine("Sobresaliente"); break;
            
            default : Console.WriteLine("Wrong mark"); break;
        }
    }
}
