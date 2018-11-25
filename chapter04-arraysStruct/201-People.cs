/*
Create a program in C # that can store info of up to 500 people. For each 
person, you must save the following information:

Name (max 40 letters)
E-mail
Address
Year of birth (short integer)

The program must allow the user the following operations:

1- Add data of a new person (you must check that the name is not empty and that 
   it is not too long).

2- Show the names of all the people stored, each in a line. If any name is 
   greater than 30 letters, the first 30 letters must be shown, followed by 
   "...". If there is no data, you must warn the user. If there are more than 20 
   people, you should pause after displaying each block of 20 names, and wait 
   for the user to press Enter before continuing.

3- Show all the data of a certain person (from his name, which must match 
   exactly, case insensitive). If that person is not found, the user should be 
   notified (this applies to all searches, not just to this one).

4- Show the names of all people whose year of birth is between two ones chosen 
   by the user (eg: between 1980 and 1990), both included. All names must be
   shown on the same line, separated by a hyphen ("-"), not paused.

5- Show the names of the oldest people (who were born in the lowest year that 
   appears among our data, for example in 1920).

6- Show all the data of the persons whose address contains some text entered
   by the user (not case sensitive). After each record, the user must press 
   "[Enter]" to continue, or type "end[Enter]" if they do not want to see more 
   data.

7- Sort the data, by name.

T- Finish the use of the application (as we do not use files, the data will be 
   lost).
*/

// Kevin Marín Romero

using System;

public class People
{
    struct Person
    {
        public string name;
        public string email;
        public string address;
        public short yearBirth;
    }
    public static void Main()
    {
        const int SIZE = 500;
        int amount = 0;
        Person[] p = new Person[SIZE];
        string[] options = {"Add Person","Show Names","Show a Person",
            "Search by Year","Show oldest People","Search by Address","Sort"};
        char option;
        
        do
        {
            Console.WriteLine("MENU");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("{0}. {1}",i+1,options[i]);
            }
            Console.WriteLine("T. Exit");
            Console.Write("Select: ");
            option = Convert.ToChar(Console.ReadLine());
            
            switch (option)
            {
                case '1': // Add
                    if (amount < SIZE)
                    {
                        Console.Write("Enter a name for {0} person: ", 
                            amount+1);
                        string name = Console.ReadLine();
                        while (name == "" || name.Length > 40)
                        {
                            Console.Write("Enter a name for {0} person again: ", 
                            amount+1);
                            name = Console.ReadLine();
                        }
                        p[amount].name = name;
                        Console.Write("Ener a email for {0} person: ",
                            amount+1);
                        p[amount].email = Console.ReadLine();
                        Console.Write("Enter direction for {0} person: ",
                            amount+1);
                        p[amount].address = Console.ReadLine();
                        Console.Write("Enter birth year for {0} person: ",
                            amount+1);
                        p[amount].yearBirth = Convert.ToInt16(
                            Console.ReadLine());
                        amount++;
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }
                    break;
                    
                case '2': // Show all
                    if (amount > 0)
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            if (p[i].name.Length <= 30)
                            {
                                Console.WriteLine("Person {0}: {1}", i+1,
                                    p[i].name);
                            }
                            else
                            {
                                Console.WriteLine("Person {0}: {1}...", i+1, 
                                    p[i].name.Substring(0,30));
                            }
                            if (i % 20 == 19)
                            {
                            Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("There aren't names");
                    }
                    break;

                case '3':  // Search name
                    Console.Write("Enter the name to search: ");
                    string search = Console.ReadLine();
                    bool isFound = false;
                    for (int i = 0; i < amount; i++)
                    {
                        if (p[i].name.ToUpper() == search.ToUpper())
                        {
                            Console.WriteLine("Person {0}", i+1);
                            Console.WriteLine("Name: {0}", p[i].name);
                            Console.WriteLine("E-Mail: {0}", p[i].email);
                            Console.WriteLine("Direction: {0}", p[i].address);
                            Console.WriteLine("Birth Year: {0}",
                                p[i].yearBirth);
                            isFound = true;
                        }
                    }
                    if (! isFound)
                    {
                        Console.WriteLine("Name not found");
                    }
                    break;

                case '4': // Names of people between two years
                    Console.Write("Enter first year: ");
                    short firstYear = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter last year: ");
                    short secondYear = Convert.ToInt16(Console.ReadLine());
                    bool isLocated = false;
                    for (int i = 0; i < amount; i++)
                    {
                        if (p[i].yearBirth >= firstYear &&
                            p[i].yearBirth <= secondYear)
                        {
                            Console.Write(p[i].name + "-");
                            isLocated = true;
                        }
                    }
                    if (! isLocated)
                    {
                        Console.Write("No matches");
                    }
                    Console.WriteLine();
                    break;
                    
                case '5': // Oldest people
                    short lowestYear = p[0].yearBirth;
                    for (int i = 1; i < amount; i++)
                    {
                        if (p[i].yearBirth < lowestYear)
                        {
                            lowestYear = p[i].yearBirth;
                        }
                    }
                    Console.WriteLine("Persons of " + lowestYear);
                    for (int i = 0; i < amount; i++)
                    {
                        if (p[i].yearBirth == lowestYear)
                        {
                            Console.WriteLine("Person {0}: {1}", i+1,p[i].name);
                        }
                    }
                    break;

                case '6': // Search address
                    Console.Write("Enter the word to search in the address: ");
                    string toSearch = Console.ReadLine();
                    int counter = 0;
                    bool addressFound = false;
                    bool stopped = false;
                    while (counter < amount && ! stopped)
                    {
                        if (p[counter].address.ToUpper().Contains(
                            toSearch.ToUpper()))
                        {
                            Console.WriteLine("Person {0}", counter+1);
                            Console.WriteLine("Name: {0}", p[counter].name);
                            Console.WriteLine("E-Mail: {0}", p[counter].email);
                            Console.WriteLine("Direction: {0}", 
                                p[counter].address);
                            Console.WriteLine("Birth Year: {0}",
                                p[counter].yearBirth);
                            addressFound = true;
                            string check = Console.ReadLine();
                            if (check == "end")
                            {
                                stopped = true;
                            }
                        }
                        counter++;
                    }
                    if (! addressFound)
                    {
                        Console.WriteLine("Address not found!");
                    }
                    break;

                case '7':  // Sort
                    if (amount > 0)
                    {
                        for (int i = 1; i < amount; i++)
                        {
                            int j = i-1;
                            while ((j >= 0) && (p[j].name.CompareTo(
                                p[j+1].name) > 0))
                            {
                                Person aux = p[j];
                                p[j] = p[j+1];
                                p[j+1] = aux;
                                j--;
                            }
                        }
                        Console.WriteLine("Sorted Correctly!!!");
                    }
                    else
                    {
                        Console.WriteLine("There aren't persons");
                    }
                    break;
                
                case 'T':  // Quit
                    break;
                
                default:   // Other: error
                    Console.WriteLine("Wrong option!"); 
                    break;
            }
            Console.WriteLine();
        }while(option != 'T');
        
        Console.WriteLine("Good Bye!!!");
    }
}
