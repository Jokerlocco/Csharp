using System;
using System.Collections;

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
        ArrayList cities = new ArrayList();

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
                    City newCity;
                    Console.Write("Enter name of city: ");
                    newCity.name = Console.ReadLine();

                    Console.Write("Enter population of city: ");
                    newCity.population = Convert.ToInt32(
                        Console.ReadLine());

                    cities.Add(newCity);
                    break;

                case 2: // View all the cities
                    for (int i = 0; i < cities.Count; i++)
                    {
                        Console.WriteLine("City {0}:", i + 1);
                        Console.WriteLine("Name: {0}", 
                            ((City) cities[i]).name);
                        Console.WriteLine("Population: {0}",
                            ((City)cities[i]).population);
                    }
                    break;

                case 3: // Edit a city
                    Console.WriteLine("Which city do you want to edit?");
                    int cityToEdit = Convert.ToInt32(Console.ReadLine()) - 1;
                    City cityData = (City)cities[cityToEdit];

                    Console.Write("Enter name of city (it was {0}): ",
                        cityData.name);
                    string newName = Console.ReadLine();
                    if (newName != "")
                        cityData.name = newName;

                    Console.Write("Enter population of city (it was {0}): ",
                        cityData.population);
                    string newPopulationAsString = Console.ReadLine();
                    if (newPopulationAsString != "")
                        cityData.population = Convert.ToInt32(
                            newPopulationAsString);

                    cities[cityToEdit] = cityData;
                    break;

                case 4: // Search in cities
                    Console.WriteLine("Which text do you want to find?");
                    string search = Console.ReadLine().ToUpper();
                    for (int i = 0; i < cities.Count; i++)
                    {
                        if (((City)cities[i]).name.ToUpper().Contains(search))
                        {
                            Console.WriteLine("City {0}:", i + 1);
                            Console.WriteLine("Name: {0}",
                                 ((City)cities[i]).name);
                            Console.WriteLine("Population: {0}",
                                 ((City)cities[i]).population);
                        }
                    }
                    break;

                case 5:  // Delete a city
                    Console.Write("Enter the position of delete: ");
                    int positionToDelete = 
                        Convert.ToInt32(Console.ReadLine()) - 1;
                    cities.RemoveAt(positionToDelete);
                    break;

                case 6:   // Insert in a certain position
                    Console.Write("Enter the position of insert: ");
                    int positionToInsert = 
                        Convert.ToInt32(Console.ReadLine()) - 1;

                    City cityToInsert;
                    Console.Write("Enter name of city: ");
                    cityToInsert.name = Console.ReadLine();

                    Console.Write("Enter population of city: ");
                    cityToInsert.population = Convert.ToInt32(
                        Console.ReadLine());

                    cities.Insert(positionToInsert,
                        cityToInsert);
                    break;

                default:
                    Console.WriteLine("Option no valid. Repeat please");
                    break;
            }
        }
        while (option != 0);
    }
}
