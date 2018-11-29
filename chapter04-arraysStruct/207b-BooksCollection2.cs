//Kevin Marín Romero

using System;
using System.Text;

public class Books
{
    struct book
    {
        public string title;
        public string author;
        public int year;
    }
    public static void Main()
    {
        const int SIZE = 25000;
        book[] b = new book[SIZE];
        int amount = 0;
        string[] options = {"Add Book","Show all Books","Search text",
            "Search between two years","Modify record","Delete record",
            "Correct spelling"};
        char option;
        
        do
        {
            Console.WriteLine("MENU");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("{0}. {1}",i+1,options[i]);
            }
            Console.WriteLine("X. Exit");
            Console.Write("Select option: ");
            option = Convert.ToChar(Console.ReadLine().ToUpper());
            
            switch (option)
            {
                case 'X':   // Exit
					Console.Write("Good Bye!!!"); 
					break;

                case '1':  // Add
                    if (amount > SIZE)
                    {
                        Console.WriteLine("Database full");
                    }
                    else
                    {
                        Console.Write("Enter the title for book {0}: ",
                            amount+1);
                        string title = Console.ReadLine();
                        
                        while (title == "")
                        {
                            Console.Write(
                                "Enter the title for book {0} again: ",
                                amount+1);
                        title = Console.ReadLine();
                        }
                        b[amount].title = title;
                        Console.Write("Enter the author for book {0}: ",
                            amount+1);
                        string author = Console.ReadLine();
                        while (author == "")
                        {
                            Console.Write(
                                "Enter the author for book {0} again: ",
                                amount+1);
                        author = Console.ReadLine();
                        }
                        b[amount].author = author;
                        Console.Write("Enter the year for book {0}: ",
                            amount+1);
                        string year = Console.ReadLine();
                        if (year == "")
                            b[amount].year = -1;
                        else
                            b[amount].year = Convert.ToInt32(year);
                            
                        amount++;
                        
                        for (int i = 0; i < amount; i++)
                        {
                            int j = i-1;
                            while ((j>=0) && (
                                (String.Compare(b[j].title,
									b[j+1].title, true) > 0) 
                                || 
                                (b[j].title == b[j+1].title 
									&& String.Compare(b[j].author,
										b[j+1].author,true) > 0)))
                            {
                                book aux = b[j];
                                b[j] = b[j+1];
                                b[j+1] = aux;
                            }
                        }
                    }
                    break;

                case '2':  // Show all
                    if (amount == 0)
                    {
                        Console.WriteLine("There aren't records");
                    }
                    else
                    {
                        Console.WriteLine();
                        for (int i = 0; i < amount; i++)
                        {
                            Console.Write("record {0}: {1}-{2}-",i+1,
                                b[i].title,b[i].author);
                            if (b[i].year == -1)
                                Console.WriteLine("Unknown year");
                            else
                                Console.WriteLine(b[i].year);
                            Console.WriteLine();
                            if (i % 21 == 20)
                                Console.ReadLine();
                        }
                    }
                    break;

                case '3':  // Search text
                    Console.Write("Enter the text to search: ");
                    string text = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    for (int i = 0; i < amount; i++)
                    {
                        if (b[i].title.ToUpper().Contains(text) ||
                            b[i].author.ToUpper().Contains(text))
                        {
                            Console.Write("record {0}: {1}-{2}-",i+1,
                                b[i].title,b[i].author);
                            if (b[i].year == -1)
                                Console.WriteLine("Unknown year");
                            else
                                Console.WriteLine(b[i].year);
                            Console.WriteLine();
                            if (i % 21 == 20)
                                Console.ReadLine();
                        }
                    }
                    break;

                case '4':  // Search date
                    Console.Write("Enter the first year of the search: ");
                    int firstYear = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second year of the search: ");
                    int secondYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (firstYear > secondYear)
                    {
                        int aux = firstYear;
                        firstYear = secondYear;
                        secondYear = aux;
                    }
                    bool isFound = false;
                    for (int i = 0; i < amount; i++)
                    {
                        if (b[i].year >= firstYear && b[i].year <= secondYear)
                        {
                            isFound = true;
                            Console.Write("record {0}: {1}-{2}-",i+1,
                                b[i].title,b[i].author);
                                if (b[i].year == -1)
                                    Console.WriteLine("Unknown year");
                                else
                                    Console.WriteLine(b[i].year);
                                Console.WriteLine();
                        }
                    }
                    if (! isFound)
                        Console.WriteLine("There aren't coincidences");
                    break;

                case '5':  // Edit record
                    Console.Write("Enter the number of the record to modify: "
                        );
                    int modify = Convert.ToInt32(Console.ReadLine())-1;
                    if (modify < 0 || modify > amount-1)
                    {
                        Console.WriteLine("Number of record incorrect");
                    }
                    else
                    {
                        Console.WriteLine("record {0}",modify+1);
                        Console.Write("New title (was {0}): ",b[modify].title);
                        string newFact = Console.ReadLine();
                        if (newFact != "")
                            b[modify].title = newFact.Trim();
                        Console.Write("New author (was {0}): ",
                            b[modify].author);
                        newFact = Console.ReadLine();
                        if (newFact != "")
                            b[modify].author = newFact.Trim();
                        Console.Write("New year (was {0}): ",b[modify].year);
                        newFact = Console.ReadLine();
                        if (newFact != "")
                            b[modify].year = Convert.ToInt32(newFact.Trim());
                            
                        if (b[modify].title == b[modify].title.ToUpper())
                            Console.WriteLine("*The title is in Uppercase");
                        else if (b[modify].title == b[modify].title.ToLower())
                            Console.WriteLine("*The title is in Lowercase");
                        if (b[modify].title.Contains("  "))
                            Console.WriteLine(
                                "*The title have redundant spaces");
                        
                        if (b[modify].author == b[modify].author.ToUpper())
                            Console.WriteLine("*The author is in Uppercase");
                        else if (b[modify].author == b[modify].author.ToLower())
                            Console.WriteLine("*The author is in Lowercase");
                        if (b[modify].author.Contains("  "))
                            Console.WriteLine(
                                "*The author have redundant spaces");
                    }
                    break;

                case '6':  // Delete
                    Console.Write("Enter the number of record to delete: ");
                    int delete = Convert.ToInt32(Console.ReadLine())-1;
                    if (delete < 0 || delete > amount-1)
                    {
                        Console.WriteLine("Number of record incorrect");
                    }
                    else
                    {
                        Console.Write("record {0}: {1}-{2}-",delete+1,
                                b[delete].title,b[delete].author);
                                if (b[delete].year == -1)
                                    Console.WriteLine("Unknown year");
                                else
                                    Console.WriteLine(b[delete].year);
                                Console.Write("Are you sure you want to " +
                                    "eliminate the record?(Y/N): ");
                                char secure = Char.ToUpper(Convert.ToChar(
									Console.ReadLine()));
                                if (secure == 'Y')
                                {
                                    for (int i = delete; i < amount; i++)
                                    {
                                        b[i] = b[i+1];
                                    }
                                    amount--;
                                    Console.WriteLine("Delete is completed");
                                }
                                else
                                    Console.WriteLine(
                                        "The record hasen't been deleted");
                    }
                    break;

                case '7':   // Correct spelling
                    for(int i = 0; i < amount; i++)
                    {
                        int j = 0;
                        while (j < b[i].title.Length)
                        {
                            if (b[i].title[j] == Char.ToLower(b[i].title[j]) &&
                                b[i].title[j+1] == Char.ToUpper(
                                b[i].title[j+1]) ||
                                b[i].title.IndexOf(" ",0,0) >= 0 || 
                                b[i].title.IndexOf(" ",b[i].title.Length-1,0)
                                >=0 || b[i].title.Contains("  "))
                            {
                                Console.Write("record {0}: {1}-{2}-",i+1,
                                b[i].title,b[i].author);
                                if (b[i].year == -1)
                                    Console.WriteLine("Unknown year");
                                else
                                    Console.WriteLine(b[i].year);
                                j = b[i].title.Length;
                            }
                            j++;
                        }
                         Console.Write(
                                "Do you want to fix this record (y/n)?: ");
                                char toCorrect = Char.ToUpper(
                                    Convert.ToChar(Console.ReadLine()));
                                if (toCorrect == 'Y')
                                {
                                    b[i].title = b[i].title.Trim();
                                    while (b[i].title.Contains("  "))
                                    {
                                        b[i].title = b[i].title.Replace(
                                            "  ", " ");
                                    }
                                    b[i].title = b[i].title.ToLower();
                                    StringBuilder word = new StringBuilder(
                                        b[i].title);
                                    word[0] = Char.ToUpper(word[0]);
                                    for (j = 0; j < b[i].title.Length-2;j++)
                                        if (word[j] == '.' && word[j+1] == ' ')
                                        {
                                            word[j+2] = Char.ToUpper(word[j+2]);
                                        }
                                   b[i].title = Convert.ToString(word);
                                }
                                Console.WriteLine("###record {0} corrected###",i+1);
                    }
                    break;
                    
                default:  // Unknow option?
					Console.WriteLine("Unknown option"); 
					break;
            }
            Console.WriteLine();
            
        } while(option != 'X');
    }
}
