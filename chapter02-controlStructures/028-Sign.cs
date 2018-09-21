// Positive, negative or zero
// Diego Aníbal Lezcano Reissner

using System;

public class Positivo {
    
    public static void Main (){
        
        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        if (a>0)
            Console.WriteLine("{0} is positive", a);
        else 
            if (a<0)
                Console.WriteLine("{0} is negative", a);
            else
                Console.WriteLine("{0} is zero",a);
    }
}
