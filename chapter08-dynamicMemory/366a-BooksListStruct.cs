// Gestión de libros

using System;
using System.Collections.Generic;

public class BooksList
{
    struct Book
    {
        public string title;
        public string author;
        public ushort year;
        public bool isElectronic;
    }

    public static void Main()
    {
        //Book[] books = new Book[SIZE];
        List<Book> books = new List<Book>();
        string option, search;

        do
        {
            // Show menu
            Console.WriteLine("1. Add new book");
            Console.WriteLine("2. Show all books");
            Console.WriteLine("3. Search book by title or author");
            Console.WriteLine("4. Edit a book");
            Console.WriteLine("5. Delete a book");
            Console.WriteLine("0. Exit");
            option = Console.ReadLine();
            Console.WriteLine();

            switch (option)
            {
                case "1": // Add new book
                    Book b;
                    do
                    {
                        Console.Write("Enter the title: ");
                        b.title = Console.ReadLine();
                        if (b.title == "")
                            Console.WriteLine("The title cannot be empty");
                    } while (b.title == "");

                    Console.Write("Enter the author: ");
                    b.author = Console.ReadLine();
                    Console.Write(
                        "Enter the year of your edition: ");
                    b.year =
                        Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Is electronic (y/n): ");
                    b.isElectronic =
                        Console.ReadLine() == "y";

                    books.Add(b);

                    Console.WriteLine();
                    break;

                case "2": // Show all books
                    if (books.Count == 0)
                    {
                        Console.WriteLine("Database is empty.");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine("Book {0}", i + 1);
                            Console.WriteLine("Title: " + books[i].title);
                            Console.WriteLine("Author: " + books[i].author);
                            Console.WriteLine("Year: " + books[i].year);
                            Console.WriteLine("Format: {0}",
                                books[i].isElectronic ? "Electronic" : "Paper");

                            Console.WriteLine();

                            if (i % 20 == 21)  // Pause after 22 lines
                                Console.ReadLine();
                        }
                    }
                    break;

                case "3": // Search book by title or author
                    Console.Write("Enter data to search: ");
                    search = Console.ReadLine().ToUpper();

                    Console.WriteLine();

                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].title.ToUpper().Contains(search) ||
                            books[i].author.ToUpper().Contains(search))
                        {
                            Console.WriteLine("Book number " + (i + 1));
                            Console.WriteLine("Title: " + books[i].title);
                            Console.WriteLine("Author: " + books[i].author);
                            Console.WriteLine("Year: " + books[i].year);
                            Console.WriteLine(
                                books[i].isElectronic ? "Electronic" : "Paper");

                            Console.WriteLine();
                        }
                    }
                    break;

                case "4": // Edit a book
                    Console.WriteLine("Enter index to edit: ");
                    int posEdit = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (posEdit < 0 || posEdit > books.Count - 1)
                        Console.WriteLine("Error, wrong number!");
                    else
                    {
                        Book bookToEdit = books[posEdit];
                        Console.WriteLine("New title (it was {0}): ",
                            bookToEdit.title);
                        string newData = Console.ReadLine();
                        if (newData != "")
                            bookToEdit.title = newData;

                        Console.WriteLine("New author (it was {0}): ",
                            bookToEdit.author);
                        newData = Console.ReadLine();
                        if (newData != "")
                            bookToEdit.author = newData;

                        Console.WriteLine("New year (it was {0}): ",
                            bookToEdit.year);
                        newData = Console.ReadLine();
                        if (newData != "")
                            bookToEdit.year = Convert.ToUInt16(newData);

                        books[posEdit] = bookToEdit;
                    }
                    break;

                case "5": // Delete a book
                    Console.WriteLine("Enter index to delete: ");
                    int posDelete = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (posDelete < 0 || posDelete > books.Count - 1)
                        Console.WriteLine("Error, wrong number!");
                    else
                    {
                        books.RemoveAt(posDelete);
                    }
                    break;
            }
        } while (option != "0");
    }
}
