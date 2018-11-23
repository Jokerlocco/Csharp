/*
Create a program in C # that can store records of up to 1000 computer programs. 
For each program, you must save the following data:

* First name
* Category (max 30 letters)
* Description
* Version (it is a set of 3 data: the version number -text-, the release month 
  -byte- and the release year - usigned short int-)

The program must allow the user the following operations:

1- Add data of a new program (the name must not be empty, you must check the 
category that the user typed is not longer than 30 letters, and if so, 
it must be asked again. For the description, it will be taken only the first 
100 letters, in case the user types more than 100. It is not necessary to 
validate the version).

2- Show the names of all stored programs. Each name must appear in a line. If 
there are more than 20 programs, you should pause after displaying each block 
of 20 programs, and wait for the user to press Enter before continuing. It 
should be notified if there is no data.

3- Show all the data of a certain program (searching in its name, category or 
description, not case sensitive). If the category has been left blank, 
"Category: No data" will be shown. If there are several programs that contain 
that text, all of them will be shown, separated by a blank line. The user 
should be notified if no program is found.

4- Edit a record (it will ask for the number, the previous value of each field 
will be shown and the user can press Enter to not modify any of the data). You 
must warn (but not ask again) if they enter an incorrect record number. It is 
not necessary to validate any of the fields.

5- Delete a certain record, in the position indicated by the user. You must 
warn (but not ask again) if they enter an incorrect number.

6- Sort the data alphabetically, according to its name.

7- Correct redundant spaces (it will turn all the sequences of two or more 
spaces into a single space, only in the name, for all the existing tiles).

T- Finish the use of the application (as we do not know how to store the 
information, the data will be lost).
*/

//Ivan Lazcano
//Saúl Cánovas
//Ruth Martínez

using System;

public class Db
{
    struct versionData
    {
        public string number;
        public byte month;
        public ushort year;
    }

    struct program
    {
        public string name;
        public string category;
        public string description;
        public versionData version;
    }

    public static void Main()
    {
        const int SIZE = 1000;
        int count = 0;
        program[] p = new program[SIZE];
        string option = "";
        string intro;
        do
        {
            Console.WriteLine("Programs:");
            Console.WriteLine();
            Console.WriteLine("1- Add a new program");
            Console.WriteLine("2- Show all programs");
            Console.WriteLine("3- Search database");
            Console.WriteLine("4- Modify file");
            Console.WriteLine("5- Delete file");
            Console.WriteLine("6- Sort database");
            Console.WriteLine("7- Erase redundant spaces");
            Console.WriteLine("T- Terminate application");
            Console.WriteLine();
            Console.WriteLine("Menu...");
            option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "1": // Add
                    if (count <= SIZE)
                    {
                        do
                        {
                            Console.Write("Enter the name: ");
                            p[count].name = Console.ReadLine();
                        }
                        while (p[count].name == "");

                        do
                        {
                            Console.Write("Enter the category: ");
                            p[count].category = Console.ReadLine();
                        }
                        while (p[count].category.Length < 30);

                        Console.Write("Enter the description: ");
                        p[count].description = Console.ReadLine();
                        if (p[count].description.Length > 100)
                            p[count].description = 
                                p[count].description.Substring(0, 100);

                        Console.Write("Enter the number version: ");
                        p[count].version.number = Console.ReadLine();

                        Console.Write("Enter the month: ");
                        p[count].version.month = Convert.ToByte(
                            Console.ReadLine());

                        Console.Write("Enter the year:  ");
                        p[count].version.year = Convert.ToUInt16(
                            Console.ReadLine());

                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }

                    break;

                case "2": // Show all
                    if (count == 0)
                    {
                        Console.WriteLine("Database is empty.");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(i + ": " + p[i].name);
                            if (i % 20 == 19)  // Pause after 20 lines
                                Console.ReadLine();
                        }
                    }
                    break;

                case "3": // Search
                    if (count == 0)
                    {
                        Console.WriteLine("Database is empty");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(
                            "Which text do you want to find? ");
                        string search = Console.ReadLine();
                        Console.WriteLine();

                        int amountFound = 0;

                        for (int i = 0; i < count; i++)
                        {
                            if ((p[i].name.ToUpper().Contains(search))
                                || (p[i].category.ToUpper().Contains(search))
                                || (p[i].description.ToUpper().Contains(search)))
                            {
                                Console.WriteLine("PROGRAM Nº{0}", i + 1);
                                Console.WriteLine("Name: {0}", p[i].name);
                                Console.WriteLine("Category: {0}", 
                                    p[i].category);
                                Console.WriteLine("Description: {0}", 
                                    p[i].description);
                                Console.WriteLine("Version {0}", 
                                    p[i].version.number);
                                Console.WriteLine("Date of release: " + 
                                    p[i].version.month + "/" + p[i].version.year);
                                Console.WriteLine();
                                amountFound++;
                            }
                        }

                        if (amountFound == 0)
                            Console.WriteLine(
                                "Can't find any program containing \"{0}\".",
                                search);

                        Console.WriteLine();
                    }
                    break;

                case "4": // Edit an entry
                    Console.WriteLine("Enter number of index");
                    int edit = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (edit < 0 || edit > count)
                        Console.WriteLine("Error, wrong number!");
                    else
                    {
                        Console.WriteLine("Name: " + );
                        Console.WriteLine("Category: " + p[edit].category);
                        Console.WriteLine("Description: "
                                          + p[edit].description);
                        Console.WriteLine("Version: "
                                          + p[edit].version.number
                                          + p[edit].version.month
                                          + p[edit].version.year);

                        Console.WriteLine("New name (it was {0}): ", 
                            p[edit].name);
                        string newData = Console.ReadLine();
                        if (newData != "")
                            p[edit].name = newData;

                        Console.WriteLine("New category (it was {0}): ",
                            p[edit].category);
                        newData = Console.ReadLine();
                        if (newData != "")
                            p[edit].category = newData;

                        Console.WriteLine("New description (it was {0}): ",
                            p[edit].description);
                        newData = Console.ReadLine();
                        if (newData != "")
                            p[edit].description = newData;

                        Console.WriteLine("New version number (it was {0}): ",
                            p[edit].version.number);
                        newData = Console.ReadLine();
                        if (newData != "")
                            p[edit].version.number = newData;

                        Console.WriteLine("New version month (it was {0}): ",
                            p[edit].version.month);
                        byte newDatab = Convert.ToByte(Console.ReadLine());
                        if (newDatab != 0)
                            p[edit].version.month = newDatab;

                        Console.WriteLine("New version year (it was {0}): ",
                            p[edit].version.year);
                        ushort newDatac = Convert.ToByte(Console.ReadLine());
                        if (newDatac != 0)
                            p[edit].version.year = newDatac;
                    }
                    break;

                case "5": // Delete
                    Console.WriteLine("Enter index to delete: ");
                    int posDelete = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (posDelete < 0 || posDelete > count)
                        Console.WriteLine("Error, wrong number!");
                    else
                    {
                        for (int i = posDelete; i < count; i++)
                        {
                            p[i] = p[i + 1];
                        }
                        count--;
                    }
                    break;

                case "6": // Sort
                    for (int i = 0; i < count - 1; i++)
                    {
                        for (int j = i + 1; j < count; j++)
                        {
                            if (p[i].name.CompareTo(p[j].name) > 0)
                            {
                                program aux = p[i];
                                p[i] = p[j];
                                p[j] = aux;
                            }
                        }
                    }
                    break;

                case "7": // Remove redundant spaces
                    for (int i = 0; i < count; i++)
                    {
                        while (p[i].name.Contains("  "))
                        {
                            p[i].name.Replace("  ", " ");
                        }
                    }
                    break;

                case "T": // Quit
                case "Q":
                    Console.WriteLine("Bye!!!");
                    break;

                default:
                    Console.WriteLine("Wrong option");
                    break;
            }

        }
        while ((option != "T") && (option != "Q"));
    }
}
