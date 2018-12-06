//Kevin Marín Romero
//Jorge Calzada Asenjo

using System;

public class BooksManagementFunctions1
{
    const int SIZE = 1000;
    static book[] p;
    static int position;

    struct book
    {
        public string title;
        public string author;
        public int year;
        public bool isElectronic;
    }

    public static void AddBook()
    {
        if (position < SIZE)
        {
            Console.Write("Enter the title for {0} book: ",
                position + 1);
            p[position].title = Console.ReadLine();
            Console.Write("Enter the author for {0} book: ",
                position + 1);
            p[position].author = Console.ReadLine();
            Console.Write(
                "Enter the year of the edition for {0} book: ",
                position + 1);
            p[position].year = Convert.ToInt32(Console.ReadLine());
            Console.Write(
                "Is the {0} book version electronic? y/n: ",
                position + 1);
            p[position].isElectronic =
                Console.ReadLine().ToLower() == "y";
            position++;
        }
        else
        {
            Console.WriteLine("The data base is full");
        }
    }

    public static void ShowBooks()
    {
        for (int i = 0; i < position; i++)
        {
            Console.WriteLine("Book {0}: ", i + 1);
            Console.WriteLine("Title: " + p[i].title);
            Console.WriteLine("Author: " + p[i].author);
            Console.WriteLine("Year: " + p[i].year);
            Console.WriteLine("Is Electronic?: {0}",
                p[i].isElectronic ? "Yes" : "No");
            Console.WriteLine();
        }
    }

    public static void SearchBook()
    {
        Console.Write("What do you want to search: ");
        string search = Console.ReadLine();
        for (int i = 0; i < position; i++)
        {
            if (p[i].title.Contains(search) ||
                p[i].author.Contains(search))
            {
                Console.WriteLine("Book {0}: ", i + 1);
                Console.WriteLine("Title: " + p[i].title);
                Console.WriteLine("Author: " + p[i].author);
                Console.WriteLine("Year: " + p[i].year);
                Console.WriteLine("Is Electronic?: {0}",
                    p[i].isElectronic ? "Yes" : "No");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        p = new book[SIZE];
        position = 0;
    
        int option;
        string[] options = { "Add Book", "Show all books", "Search" };

        do
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, options[i]);
            }
            Console.WriteLine("0. Exit");

            option = Convert.ToInt32(Console.ReadLine());

            if (option != 0)
            {
                switch (option)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        ShowBooks();
                        break;
                    case 3:
                        SearchBook();
                        break;
                    case 0: 
                        break;
                    default: 
                        Console.WriteLine("Repeat please"); break;
                }
                Console.WriteLine();
            }

        } while (option != 0);

        Console.WriteLine("Good Bye");
    }
}
