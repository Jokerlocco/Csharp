using System;

public class StructCity
{
    struct city
    {
        public string name;
        public long population;
    }
    
    public static void Main()
    {
        city c;
        
        c.name = "Alicante";
        c.population = 342567;
        
        Console.WriteLine("City 1:");
        Console.WriteLine("Name: {0}", c.name);
        Console.WriteLine("Population: {0}", c.population);
    }
}
