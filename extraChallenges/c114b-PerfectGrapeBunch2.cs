// Adrián Navarro Gabino

using System;

public class BunchesOfGrapes
{
    public static void Main()
    {
        int grapes;
        
        do
        {
            grapes = Convert.ToInt32(Console.ReadLine());
            
            if(grapes != 0)
            {
                double level = (-1 + Math.Sqrt(1 + 8 * grapes)) / 2;
                
                Console.WriteLine(Convert.ToInt32(Math.Ceiling(level)));
            }
        }while(grapes != 0);
    }
}
