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
        int option;
        const int SIZE = 1000;
        city[] c = new city[SIZE];
        int countCities = 0;
        
        do 
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Enter city");
            Console.WriteLine("2. View cities");
            Console.WriteLine("0. Exit");
            Console.Write("Enter option: ");
            option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    if (countCities < SIZE)
                    {
                        Console.Write("Enter name of city: ");
                        c[countCities].name = Console.ReadLine();
                        
                        Console.Write("Enter population of city: ");
                        c[countCities].population = Convert.ToInt32(
                            Console.ReadLine());
                        countCities++;
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }
                    break;
                case 2:
                    for (int i = 0; i < countCities; i++)
                    {
                        Console.WriteLine("City {0}:", i+1);
                        Console.WriteLine("Name: {0}", c[i].name);
                        Console.WriteLine("Population: {0}",
                            c[i].population);
                    }
                    break;    
            }
        }
        while(option != 0);
    }
}
