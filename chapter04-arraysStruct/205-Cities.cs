/*
Create a C# program that can store up to 20000 cities. For each city,
it must allow the user to store the following information:

-   Name (e.g. Alicante)
-   Country (e.g. Spain)
-   Population (e.g. 300.000)

The program should allow the user to perform the following operations:

1 - Add a new city. The name and country cannot be empty. An unknown
population (blank input) should be stored as a 0.

2 - Show all the cities, each city in a line (record number, name and
country, as in "1- Alicante, Spain"). If the name of the city is more
than 20 characters long, you must display the first 20 characters
followed by "…". If the name of the country is more than 40 characters
long, you must truncate it to 40 characters and then remove all the
spaces in it. You must pause after every 24 rows. If the user presses
Enter and does not type any text, the next 24 data will be shown, but
if they enter "stop" and then they press Enter, no more data will be
displayed.

3 - Find cities containing a certain text in its name or the name of
the country (partial search, not case sensitive). You must display the
record number, the name, country and population, in the same line,
pausing after every 24 rows. If no population was entered, you must
display "Unknown population" instead of 0.

4 - Update a record: ask the user for its number, display the previous
value of each field and allow the user to press Enter if they choose
not to modify any of the data. They should be asked again if they enter
an incorrect record number, as many times as needed (but they can type
0 to exit not updating any record). Before storing the data, leading
spaces, trailing spaces and duplicated spaces should be removed.

5 - Insert a record, in the position entered by the user. They should
be warned (but not asked again) if they enter an incorrect record
number or if the array is full. Validate data as in option 1.

6 - Delete a record, in the position entered by the user. They should
be warned (but not asked again) if they enter an incorrect record
number. Your program should display the record to be deleted and ask
for confirmation before the deletion. Also, you must warn the user if
the last data has just been erased.

7 - Sort data. The user will be asked if they want to sort based on the
name of the city or on the name of the country, and the program will
act accordingly.

8 - Find possible spelling mistakes: it will display the records
containing two consecutive punctuation symbols (.. or ,,) or a letter
repeated three times (such as Misssissippi).

Q - Quit the application (as we do not store the information on file,
data will be lost).
*/

// Adrián Navarro y Jorge Calzada

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct city
{
    public string name;
    public string country;
    public long population;
}

class CitiesDatabase
{
    static void Main(string[] args)
    {
        const int SIZE = 20000;
        city[] c = new city[SIZE];
        int actualCity = 0;

        const string ADD = "1";
        const string SHOW = "2";
        const string SEARCH = "3";
        const string EDIT = "4";
        const string INSERT = "5";
        const string DELETE = "6";
        const string SORT = "7";
        const string ORTO_ERRORS = "8";
        const string EXIT = "Q";

        string option = "";

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a city");
            Console.WriteLine("2. Show all cities");
            Console.WriteLine("3. Search a city by name or country");
            Console.WriteLine("4. Edit a city");
            Console.WriteLine("5. Insert a city");
            Console.WriteLine("6. Delete a city");
            Console.WriteLine("7. Sort cities");
            Console.WriteLine("8. Find possible spelling mistakes");
            option = Console.ReadLine();

            switch (option)
            {
                case ADD:
                    if (actualCity < SIZE)
                    {
                        Console.Write("Enter the name: ");
                        c[actualCity].name = Console.ReadLine();

                        while (c[actualCity].name == "")
                        {
                            Console.Write("The name of the city cannot be " +
                                          "empty. Please re-enter it: ");
                            c[actualCity].name = Console.ReadLine();
                        }

                        Console.Write("Enter the country: ");
                        c[actualCity].country = Console.ReadLine();

                        while (c[actualCity].country == "")
                        {
                            Console.Write("The name of the country cannot be " +
                                          "empty. Please re-enter it: ");
                            c[actualCity].country = Console.ReadLine();
                        }

                        string populationString;
                        Console.Write("Enter the name: ");
                        populationString = Console.ReadLine();

                        c[actualCity].population = populationString != ""
                            ? Convert.ToInt64(
                                populationString)
                            : (long)0;

                        actualCity++;

                        Console.WriteLine("City added successfully");
                    }
                    else
                    {
                        Console.WriteLine("There's no space in the memory.");
                    }

                    Console.WriteLine();
                    break;

                case SHOW:
                    if (actualCity == 0)
                    {
                        Console.WriteLine("No cities to show");
                    }
                    else
                    {
                        for (int i = 0; i < actualCity; i++)
                        {
                            string contin = "";

                            do
                            {
                                string auxName, auxCountry;
                                if (c[i].name.Length > 20)
                                {
                                    auxName = c[i].name.Substring(0, 20);
                                    auxName += "...";
                                }
                                else
                                {
                                    auxName = c[i].name;
                                }
                                if (c[i].country.Length > 40)
                                {
                                    auxCountry = c[i].country.Substring(0, 40);
                                }
                                else
                                {
                                    auxCountry = c[i].country;
                                }
                                Console.WriteLine("{0}- {1}, {2}", i + 1,
                                    auxName, auxCountry);

                                if (i % 24 == 23)
                                {
                                    contin = Console.ReadLine();
                                }
                            } while (contin != "fin");
                        }
                    }
                    Console.WriteLine();
                    break;

                case SEARCH:
                    bool found = false;
                    string search;

                    Console.Write("Enter the search: ");
                    search = Console.ReadLine().ToLower();

                    for (int i = 0; i < actualCity; i++)
                    {
                        if (c[i].name.ToLower().Contains(search) ||
                            c[i].country.ToLower().Contains(search))
                        {
                            Console.WriteLine("City {0}", i + 1);
                            Console.WriteLine("  Name: {0}", c[i].name);
                            Console.WriteLine("  Country: {0}", c[i].country);
                            if (c[i].population == 0)
                            {
                                Console.WriteLine("  Population: Unknown " +
                                    "population");
                            }
                            else
                            {
                                Console.WriteLine("  Population: {0}",
                                    c[i].population);
                            }

                            found = true;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("No results");
                    }

                    Console.WriteLine();
                    break;

                case EDIT:
                    int posEdit;
                    string auxEdit;
                    do
                    {
                        Console.Write("Enter the position you want to edit: ");
                        posEdit = Convert.ToInt32(Console.ReadLine()) - 1;
                    } while (posEdit > actualCity);
                    if(posEdit == 0)
                    {
                        Console.WriteLine("You don't want to edit any city");
                    }
                    else
                    {
                        Console.WriteLine("Old name: " + c[posEdit].name);
                        Console.Write("New name: ");
                        auxEdit = Console.ReadLine();
                        if(auxEdit != "")
                        {
                            c[posEdit].name = auxEdit;
                        }
                        Console.WriteLine("Old country: " + c[posEdit].country);
                        Console.Write("New country: ");
                        auxEdit = Console.ReadLine();
                        if (auxEdit != "")
                        {
                            c[posEdit].country = auxEdit;
                        }
                        Console.WriteLine("Old population: " +
                            c[posEdit].population);
                        Console.Write("New population: ");
                        auxEdit = Console.ReadLine();
                        if (auxEdit != "")
                        {
                            c[posEdit].population = Convert.ToInt32(auxEdit);
                        }
                    }

                    c[posEdit].name = c[posEdit].name.Trim();
                    c[posEdit].country = c[posEdit].country.Trim();

                    while(c[posEdit].name.Contains("  "))
                    {
                        c[posEdit].name = c[posEdit].name.Replace("  ", " ");
                    }
                    while (c[posEdit].country.Contains("  "))
                    {
                        c[posEdit].country = c[posEdit].country.Replace("  ", " ");
                    }
                    Console.WriteLine();
                    break;

                case INSERT:
                    if (actualCity < SIZE)
                    {
                        Console.Write("Enter the number of the position" +
                            " where you want to insert the city: ");
                        int numberInsert = Convert.ToInt32(
                            Console.ReadLine()) - 1;

                        if (numberInsert < actualCity)
                        {
                            city aux;

                            for (int i = actualCity; i > numberInsert; i--)
                            {
                                aux = c[i];
                                c[i] = c[i - 1];
                                c[i - 1] = aux;
                            }

                            Console.Write("Enter the name: ");
                            c[numberInsert].name = Console.ReadLine();

                            while (c[numberInsert].name == "")
                            {
                                Console.Write("The name of the city cannot be " +
                                    "empty. Please re-enter it: ");
                                c[numberInsert].name = Console.ReadLine();
                            }

                            Console.Write("Enter the country: ");
                            c[numberInsert].country = Console.ReadLine();

                            while (c[numberInsert].country == "")
                            {
                                Console.Write("The name of the country " +
                                    "cannot be empty. Please re-enter it: ");
                                c[numberInsert].country = Console.ReadLine();
                            }

                            string populationInsertString;
                            Console.Write("Enter the name: ");
                            populationInsertString = Console.ReadLine();

                            c[numberInsert].population =
                                             populationInsertString != ""
                                             ? Convert.ToInt64(
                                                 populationInsertString)
                                             : (long)0;

                            actualCity++;

                            Console.WriteLine("City added successfully");
                        }
                        else
                        {
                            Console.WriteLine("The number entered does not " +
                                "correspond to any occupied position");
                        }
                    }
                    else
                    {
                        Console.WriteLine("There's no space in the memory.");
                    }

                    Console.WriteLine();
                    break;

                case DELETE:
                    Console.Write("Enter the number of the city to be " +
                        "delete: ");
                    int numberDelete = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (numberDelete < actualCity)
                    {
                        Console.WriteLine("City {0}", numberDelete + 1);
                        Console.WriteLine("  Name: {0}",
                            c[numberDelete].name);
                        Console.WriteLine("  Country: {0}",
                            c[numberDelete].country);
                        if (c[numberDelete].population == 0)
                        {
                            Console.WriteLine("  Population: Unknown " +
                                "population");
                        }
                        else
                        {
                            Console.WriteLine("  Population: {0}",
                                c[numberDelete].population);
                        }

                        Console.Write("Delete (yes/no)?");
                        bool delete = Console.ReadLine().ToLower() == "yes";

                        if (delete)
                        {
                            city aux;
                            for (int i = numberDelete; i < actualCity; i++)
                            {
                                aux = c[i];
                                c[i] = c[i + 1];
                                c[i + 1] = aux;
                            }

                            actualCity--;

                            Console.WriteLine("City deleted successfully");

                            if (actualCity == 0)
                            {
                                Console.WriteLine("Database empty");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The city hasn't been erased.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("The number entered does't " +
                            "correspond to any city");
                    }

                    Console.WriteLine();
                    break;

                case SORT:
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Sort cities by name");
                    Console.WriteLine("2. Sort cities by country");
                    string optionSort = Console.ReadLine();
                    city auxSort;

                    if(optionSort == "1")
                    {
                        for(int i = 0; i < actualCity - 1; i++)
                        {
                            for(int j = i + 1; j < actualCity; j++)
                            {
                                if(c[i].name.CompareTo(c[j].name) > 0)
                                {
                                    auxSort = c[i];
                                    c[i] = c[j];
                                    c[j] = auxSort;
                                }
                            }
                        }
                    }
                    if (optionSort == "2")
                    {
                        for (int i = 0; i < actualCity - 1; i++)
                        {
                            for (int j = i + 1; j < actualCity; j++)
                            {
                                if (c[i].country.CompareTo(c[j].country) > 0)
                                {
                                    auxSort = c[i];
                                    c[i] = c[j];
                                    c[j] = auxSort;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong option");
                    }
                    Console.WriteLine();
                    break;

                case ORTO_ERRORS:
                    found = false;
                    for(int i = 0; i < actualCity; i++)
                    {
                        bool tripleLetter = false;
                        for (int j = 0; j < c[i].name.Length - 2; j++)
                        {
                            if (c[i].name[j] == c[i].name[j + 1] &&
                                c[i].name[j + 1] == c[i].name[j + 2])
                                tripleLetter = true;
                        }
                        for (int j = 0; j < c[i].country.Length - 2; j++)
                        {
                            if (c[i].country[j] == c[i].country[j + 1] &&
                                c[i].country[j + 1] == c[i].country[j + 2])
                                tripleLetter = true;
                        }

                        if (c[i].name.Contains("..") || c[i].name.Contains(",,")
                            || c[i].country.Contains("..") || c[i].country.Contains("..")
                            || tripleLetter)
                        {
                            string auxName, auxCountry;
                            if (c[i].name.Length > 20)
                            {
                                auxName = c[i].name.Substring(0, 20);
                                auxName += "...";
                            }
                            else
                            {
                                auxName = c[i].name;
                            }
                            if (c[i].country.Length > 40)
                            {
                                auxCountry = c[i].country.Substring(0, 40);
                            }
                            else
                            {
                                auxCountry = c[i].country;
                            }
                            Console.WriteLine("{0}- {1}, {2}", i + 1,
                                auxName, auxCountry);
                        }
                    }
                    Console.WriteLine();
                    break;

                case EXIT:
                    Console.WriteLine("Bye!");
                    break;

                default:
                    Console.WriteLine("Wrong option");
                    Console.WriteLine();
                    break;
            }
        } while (option != "Q");
    }
}
