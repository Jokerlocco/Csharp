// Araceli Yáñez Muñoz
// Ruth Martínez Iborra

using System;
public class Books2Functions
{
    struct books
    {
        public string title;
        public string author;
        public ushort year;
        public bool isElectronic;
    }

    const int SIZE = 1000;
    static books[] b;
    static int count;

    public static void AddNewBook()
    {
        if (count < SIZE)
        {
            do
            {
                Console.Write("Enter the title: ");
                b[count].title = Console.ReadLine();
                if (b[count].title == "")
                    Console.WriteLine("The title cannot be empty");
            } while (b[count].title == "");

            Console.Write("Enter the author: ");
            b[count].author = Console.ReadLine();
            Console.Write("Enter the year of your edition: ");
            b[count].year =
                Convert.ToUInt16(Console.ReadLine());
            Console.Write("Is electronic (y/n): ");
            b[count].isElectronic = Console.ReadLine() == "y";

            count++;
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Database full");
        }
    }


    public static void ShowAllBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("Database is empty.");
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Book {0}", i + 1);
                Console.WriteLine("Title: " + b[i].title);
                Console.WriteLine("Author: " + b[i].author);
                Console.WriteLine("Year: " + b[i].year);
                Console.WriteLine("Format: {0}",
                    b[i].isElectronic ? "Electronic" : "Paper");

                Console.WriteLine();

                if (i % 20 == 21)  // Pause after 22 lines
                    Console.ReadLine();
            }
        }
    }


    public static void SearchBookByTitleAuthor()
    {
        Console.Write("Enter data to search: ");
        string search = Console.ReadLine().ToUpper();

        Console.WriteLine();

        for (int i = 0; i < count; i++)
        {
            if (b[i].title.ToUpper().Contains(search) ||
                b[i].author.ToUpper().Contains(search))
            {
                Console.WriteLine("Book number " + (i + 1));
                Console.WriteLine("Title: " + b[i].title);
                Console.WriteLine("Author: " + b[i].author);
                Console.WriteLine("Year: " + b[i].year);
                Console.WriteLine(
                    b[i].isElectronic ? "Electronic" : "Paper");

                Console.WriteLine();
            }
        }
    }


    public static void EditBook()
    {
        Console.WriteLine("Enter index to edit: ");
        int posEdit = Convert.ToInt32(Console.ReadLine()) - 1;
        if (posEdit < 0 || posEdit > count - 1)
            Console.WriteLine("Error, wrong number!");
        else
        {
            Console.WriteLine("New title (it was {0}): ",
                b[posEdit].title);
            string newData = Console.ReadLine();
            if (newData != "")
                b[posEdit].title = newData;

            Console.WriteLine("New author (it was {0}): ",
                b[posEdit].author);
            newData = Console.ReadLine();
            if (newData != "")
                b[posEdit].author = newData;

            Console.WriteLine("New year (it was {0}): ",
                b[posEdit].year);
            newData = Console.ReadLine();
            if (newData != "")
                b[posEdit].year = Convert.ToUInt16(newData);
        }
    }


    public static void DeleteBook()
    {
        Console.WriteLine("Enter index to delete: ");
        int posDelete = Convert.ToInt32(Console.ReadLine()) - 1;
        if (posDelete < 0 || posDelete > count - 1)
            Console.WriteLine("Error, wrong number!");
        else
        {
            for (int i = posDelete; i < count; i++)
            {
                b[i] = b[i + 1];
            }
            count--;
        }
    }


    public static void ShowMenu()
    {
        Console.WriteLine("1. Add new book");
        Console.WriteLine("2. Show all books");
        Console.WriteLine("3. Search book by title or author");
        Console.WriteLine("4. Edit a book");
        Console.WriteLine("5. Delete a book");
        Console.WriteLine("0. Exit");
    }


    public static void Main()
    {
        b = new books[SIZE];
        count = 0;
        string option;

        do
        {
            ShowMenu();
            option = Console.ReadLine();
            Console.WriteLine();

            switch (option)
            {
                case "1": // Add new book
                    AddNewBook();
                    break;

                case "2": // Show all books
                    ShowAllBooks();
                    break;

                case "3": // Search book by title or author
                    SearchBookByTitleAuthor();
                    break;

                case "4": // Edit a book
                    EditBook();
                    break;

                case "5": // Delete a book
                    DeleteBook();
                    break;
            }
        } while (option != "0");
    }
}
