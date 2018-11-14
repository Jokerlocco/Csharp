//Ivan Lazcano Sindin
using System;
public class ArrayOfStruct
{
    struct book
    {
        public string title;
        public string autor;
        public int year;
        public bool isElectronic;
    }

    public static void Main()
    {
        const int SIZE = 3;
        book[] arrayOfBooks = new book[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter title: ");
            arrayOfBooks[i].title = Console.ReadLine();

            Console.Write("Enter autor: ");
            arrayOfBooks[i].autor = Console.ReadLine();

            Console.Write("Enter year: ");
            arrayOfBooks[i].year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Is it electronic? (y/n): ");
            arrayOfBooks[i].isElectronic = Console.ReadLine().ToLower() == "y";
        }


        foreach (book b in arrayOfBooks)
        {
            Console.WriteLine("Title: " + b.title);
            Console.WriteLine("Autor: " + b.autor);
            Console.WriteLine("Year: " + b.year);
            Console.WriteLine("Electronic : " + b.isElectronic);
        }
    }
}
