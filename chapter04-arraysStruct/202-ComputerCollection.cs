// María González Martínez
// Ordenadores clásicos (examen 2012-2013)

/*
Create a C# program that can store up to 600 records of classical computers. 
For each computer, you must keep the following data:

• Brand Name (eg Amstrad)
• Model (eg CPC664)
• Year (eg 1984)
• RAM (set of 2 data: the measure unit, eg Kb, and size, eg 64)
• Comments

The program should allow the user the following operations:

1 - Add a new computer data (the brand must not be empty, the model should not 
occupy more than 50 letters, and if any of them is not valid, it must be 
entered again. If the year is before 1900, it should be stored as 0, to 
indicate that it is not valid).

2 - Show all brands and models of computers stored. Each computer (brand and 
model) should appear on one line, separated by a hyphen (eg "Amstrad - 
CPC664"). The program should pause after displaying each block of 24 computers, 
display the message "Press Enter to continue" and wait until the user presses 
Enter. The user should be notified if there is no data.

3 - Search for computers that contain a certain text (as part of its brand, 
model or comments, case insensitive). If the year is 0, it should display: 
"Year: unknown." Data must be displayed on separate lines, with an extra blank 
line after each computer. The user should be notified if none is found.

4 - Update a record (the program will ask for the number, will display the 
previous value of each field and the user can press Enter not to modify any of 
the data). The user should be warned (but not asked again) if he enters an 
incorrect record number. It is not necessary to validate any of the fields.

5 - Delete some data, in the position indicated by the user. The user should be 
warned (but not asked again) if he enters an incorrect record number.

6 - Insert data in a position chosen by the user (by moving the rest of the 
records to the right). The user should be warned (but not asked again) if he 
enters an incorrect record number.

7 - Sort the data alphabetically by brand+model.

8 - Remove extra spaces (initial and final spaces in all the brands, models and 
comments. For example, a comment like " Test Data " would become "Test Data".

Q - Quit (end the application; as we do not store the information, will be lost).
*/

using System;
public class ComputerCollection
{
    struct ramData
    {
        public string unitMesure;
        public byte size;
    }

    struct computer
    {
        public string brand;
        public string model;
        public ushort year;
        public ramData ram;
        public string comments;
    }

    public static void Main()
    {
        const int SIZE = 600;
        int count = 0;
        computer[] c = new computer[SIZE];
        string option = "";
        
        do
        {
            Console.WriteLine("Computers:");
            Console.WriteLine();
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Show all");
            Console.WriteLine("3- Search");
            Console.WriteLine("4- Edit");
            Console.WriteLine("5- Delete");
            Console.WriteLine("6- Insert");
            Console.WriteLine("7- Sort");
            Console.WriteLine("8- Remove spaces");
            Console.WriteLine("Q- Finish");
            Console.WriteLine();
            Console.WriteLine("Menu...");
            option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "1": // Add
                    if (count < SIZE)
                    {
                        do
                        {
                            Console.Write("Enter the brand: ");
                            c[count].brand = Console.ReadLine();
                        }
                        while (c[count].brand == "");

                        do
                        {
                            Console.Write("Enter the model: ");
                            c[count].model = Console.ReadLine();
                        }
                        while (c[count].model.Length > 50);

                        Console.Write("Enter the year: ");
                        c[count].year = 
                            Convert.ToUInt16(Console.ReadLine());
                        if (c[count].year < 1900)
                            c[count].year = 0;

                        Console.Write(
                            "Enter the RAM (1-unit of measure): ");
                        c[count].ram.unitMesure = Console.ReadLine();
                            
                        Console.Write("Enter the RAM (2-size): ");
                        c[count].ram.size =
                            Convert.ToByte(Console.ReadLine());

                        Console.Write("Enter the comments: ");
                        c[count].comments = Console.ReadLine();

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
                            Console.WriteLine(c[i].brand + "-" + c[i].model);
                            if (i % 24 == 23)  // Pause after 24 lines
                            {
                                Console.Write("Press Enter to continue ");
                                Console.ReadLine();
                            }
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
                        string search = Console.ReadLine().ToUpper();

                        int amountFound = 0;

                        for (int i = 0; i < count; i++)
                        {
                            if ((c[i].brand.ToUpper().Contains(search))
                                || (c[i].model.ToUpper().Contains(search))
                                || (c[i].comments.ToUpper().Contains(search)))
                            {
                                Console.WriteLine("COMPUTER Nº{0}", i+1);
                                Console.WriteLine("Brand: {0}",c[i].brand);
                                Console.WriteLine("Model: {0}",c[i].model);
                                Console.Write("Year: ");
                                if(c[i].year == 0)
                                    Console.WriteLine("unknown");
                                else
                                    Console.WriteLine(c[i].year);
                                Console.Write("RAM (1-unit of measure): {0}", 
                                    c[i].ram.unitMesure);
                                Console.Write("RAM (2-size): {0}",
                                    c[i].ram.size);
                                Console.Write("Comments: {0}",c[i].comments);
                                Console.WriteLine();
                                amountFound++;
                            }
                        }

                        if (amountFound == 0)
                            Console.WriteLine("Not found");

                        Console.WriteLine();
                    }
                    break;

                case "4": // Edit
                    Console.WriteLine("Enter number of index: ");
                    int edit = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (edit < 0 || edit > count-1)
                        Console.WriteLine("Error, wrong number!");
                    else
                    {
                        Console.WriteLine("New brand (it was {0}): ", 
                            c[edit].brand);
                        string newData = Console.ReadLine();
                        if (newData != "")
                            c[edit].brand = newData;

                        Console.WriteLine("New model (it was {0}): ",
                            c[edit].model);
                        newData = Console.ReadLine();
                        if (newData != "")
                            c[edit].model = newData;

                        Console.WriteLine("New year (it was {0}): ",
                            c[edit].year);
                        ushort newDataY = Convert.ToUInt16(Console.ReadLine());
                        if (newDataY != 0)
                            c[edit].year = newDataY;

                        Console.WriteLine(
                            "New RAM (1-unit of measure) (it was {0}): ",
                            c[edit].ram.unitMesure);
                        newData = Console.ReadLine();
                        if (newData != "")
                            c[edit].ram.unitMesure = newData;

                        Console.WriteLine("New RAM (2-size) (it was {0}): ",
                            c[edit].ram.size);
                        byte newDataS = Convert.ToByte(Console.ReadLine());
                        if (newDataS != 0)
                            c[edit].ram.size = newDataS;

                        Console.WriteLine("New comments (it was {0}): ",
                            c[edit].comments);
                        newData = Console.ReadLine();
                        if (newData != "")
                            c[edit].comments = newData;
                    }
                    break;

                case "5": // Delete
                    Console.WriteLine("Enter index to delete: ");
                    int posDelete = Convert.ToInt32(Console.ReadLine())-1;
                    
                    if (posDelete < 0 || posDelete > count-1)
                        Console.WriteLine("Error, wrong number!");
                    else
                    {
                        for (int i = posDelete; i < count-1; i++)
                        {
                            c[i] = c[i + 1];
                        }
                        count--;
                    }
                    break;
                
                case "6": // Insert
                    if(count <= SIZE)
                    {
                        Console.Write("Enter the position of insertion: ");
                        int posInsert = Convert.ToInt32(Console.ReadLine())-1;
                        
                        if (posInsert < 0 || posInsert > count-1)
                            Console.WriteLine("Error, wrong number!");
                        else
                        {
                            for (int i = count; i > posInsert; i--)
                            {
                                c[i] = c[i-1];
                            }
                            
                            do
                            {
                                Console.Write("Enter the brand: ");
                                c[count].brand = Console.ReadLine();
                            }
                            while (c[count].brand == "");

                            do
                            {
                                Console.Write("Enter the model: ");
                                c[count].model = Console.ReadLine();
                            }
                            while (c[count].model.Length > 50);

                            Console.Write("Enter the year: ");
                            c[count].year = 
                                Convert.ToUInt16(Console.ReadLine());
                            if (c[count].year < 1900)
                                c[count].year = 0;

                            Console.Write(
                                "Enter the RAM (1-unit of measure): ");
                            c[count].ram.unitMesure = Console.ReadLine();
                                
                            Console.Write("Enter the RAM (2-size): ");
                            c[count].ram.size =
                                Convert.ToByte(Console.ReadLine());

                            Console.Write("Enter the comments: ");
                            c[count].comments = Console.ReadLine();
                            
                            count++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }
                    break;
                
                case "7": // Sort
                    for (int i = 0; i < count - 1; i++)
                    {
                        for (int j = i + 1; j < count; j++)
                        {
                            int criteria1 = c[i].brand + c[i].model;
                            int criteria2 = c[j].brand + c[j].model;
                            if (criteria1.CompareTo(criteria2) > 0)
                            {
                                computer aux = c[i];
                                c[i] = c[j];
                                c[j] = aux;
                            }
                        }
                    }
                    break;

                case "8": // Remove spaces
                    for (int i = 0; i < count; i++)
                    {
                        while (c[i].brand.Contains("  "))
                        {
                            c[i].brand = c[i].brand.Replace("  ", " ");
                        }
                        while (c[i].model.Contains("  "))
                        {
                            c[i].model = c[i].model.Replace("  ", " ");
                        }
                        while (c[i].comments.Contains("  "))
                        {
                            c[i].comments = c[i].comments.Replace("  ", " ");
                        }
                        c[i].brand = c[i].brand.Trim();
                        c[i].model = c[i].model.Trim();
                        c[i].comments = c[i].comments.Trim();
                    }
                    break;
                    
                case "Q": // Finish
                    break;

                default:
                    Console.WriteLine("Wrong option");
                    break;
            }

        } while (option != "Q");
        
        Console.WriteLine("Bye!!!");
    }
}
