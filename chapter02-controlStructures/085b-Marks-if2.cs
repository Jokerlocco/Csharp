// Marks, if (2)

using System;
public class IfMarks2
{
    public static void Main()
    {
        Console.Write("Enter your mark: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        
        if((mark == 9) || (mark == 10))
            Console.WriteLine("Sobresaliente");
        else if((mark == 7) || (mark == 8))
            Console.WriteLine("Notable");
        else if(mark == 6)
            Console.WriteLine("Bien");
        else if(mark == 5)
            Console.WriteLine("Aprobado");
        else if((mark <= 4) && (mark >= 0))
            Console.WriteLine("Suspenso");
        else
            Console.WriteLine("Wrong mark");
    }
}
        
