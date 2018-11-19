// Jorge Calzada

using System;

public class StructCity2
{
    struct City
    {
        public string name;
        public long population;
    }

    public static void Main()
    {
        int option;
        const int SIZE = 1000;
        City[] c = new City[SIZE];
        int countCities = 0;
        int position;

        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add a city");
            Console.WriteLine("2. View all cities");
            Console.WriteLine("3. Edit a city");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Insert in position");
            Console.WriteLine("0. Exit");
            Console.Write("Enter option: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    break;
                case 1: // Add a new city
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

                case 2: // View all the cities
                    for (int i = 0; i < countCities; i++)
                    {
                        Console.WriteLine("City {0}:", i + 1);
                        Console.WriteLine("Name: {0}", c[i].name);
                        Console.WriteLine("Population: {0}",
                            c[i].population);
                    }
                    break;

                case 3: // Edit a city
                    Console.WriteLine("Which city do you want to edit?");
                    int cityToEdit = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.Write("Enter name of city (it was {0}): ",
                        c[cityToEdit].name);
                    string newName = Console.ReadLine();
                    if (newName != "")
                        c[cityToEdit].name = newName;

                    Console.Write("Enter population of city (it was {0}): ",
                        c[cityToEdit].population);
                    string newPopulationAsString = Console.ReadLine();
                    if (newPopulationAsString != "")
                        c[cityToEdit].population = Convert.ToInt32(
                            newPopulationAsString);

                    break;

                case 4: // Search in cities
                    Console.WriteLine("Which text do you want to find?");
                    string search = Console.ReadLine().ToUpper();
                    for (int i = 0; i < countCities; i++)
                    {
                        if (c[i].name.ToUpper().Contains(search))
                        {
                            Console.WriteLine("City {0}:", i + 1);
                            Console.WriteLine("Name: {0}", c[i].name);
                            Console.WriteLine("Population: {0}",
                                c[i].population);
                        }
                    }
                    break;

                case 5:  // Delete a city
                    Console.Write("Enter the position of delete: ");
                    position = Convert.ToInt32(Console.ReadLine())-1;
                    for (int i = position; i < countCities; i++)
                    {
                        c[i] = c[i + 1];
                    }
                    countCities--;
                    break;

                case 6:   // Insert in a certain position
                    if (countCities < SIZE)
                    {
                        Console.Write("Enter the position of insert: ");
                        position = Convert.ToInt32(Console.ReadLine()) - 1;

                        for (int i = countCities; i > position; i--)
                        {
                            c[i] = c[i - 1];
                        }

                        Console.Write("Enter name of city: ");
                        c[position].name = Console.ReadLine();

                        Console.Write("Enter population of city: ");
                        c[position].population = Convert.ToInt32(
                            Console.ReadLine());

                        countCities++;
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }
                    break;

                default:
                    Console.WriteLine("Option no valid. Repeat please");
                    break;
            }
        }
        while (option != 0);
    }
}
