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
        const int SIZE = 3;
        city[] c = new city[SIZE];
        
        c[0].name = "Alicante";
        c[0].population = 342567;
        c[1].name = "Valencia";
        c[1].population = 825257;
        c[2].name = "Albacete";
        c[2].population = 552346;
        
        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("City {0}:", i+1);
            Console.WriteLine("Name: {0}", c[i].name);
            Console.WriteLine("Population: {0}", c[i].population);
        }
        
    }
}
