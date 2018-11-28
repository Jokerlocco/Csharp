/*
Create a C# program that can store up to 25000 books. For each book, it must 
allow the user to store the following information:

- Title (e.g. The shining)
- Author (e.g. Stephen King)
- Year published (e.g. 1977)

The program should allow the user to perform the following operations :

1 - Add a new book. The title and author cannot be empty. An empty year should 
be stored as a -1. Data must be automatically sorted on title and (if 
necessary) author after each new data is added.

2 - Show all the books (record number, title, author and year), pausing after 
every 21 rows. If no year was entered, you must display "Unknown year" instead 
of -1.

3 - Find books containing a certain text (partial search, in any text field, 
not case sensitive). You must display the record number, the title, author and 
year, pausing after every 21 rows.

4 - Find books published between two dates (for example, 1970 and 1985), both 
included. Again, you must display the record number, the title, author and 
year, but there is no need for pause. It must behave correctly if the user 
enters the later date first.

5 - Update a record: ask the user for its number, display the previous value of 
each field and allow the user to press Enter if they choose not to modify any 
of the data. They should be warned (but not asked again) if they enter an 
incorrect record number. Before storing the data, leading and trailing spaces 
should be removed. The user will be warned if title or author are completely 
uppercase, completely lowercase or contains redundant spaces.

6 - Delete a record, in the position entered by the user. They should be warned 
(but not asked again) if they enter an incorrect record number. It should 
display the record to be deleted and ask for confirmation before the deletion.

7 - Correct spelling in the titles: it will display the records containing two 
consecutive spaces, leading or trailing spaces, or an uppercase letter right 
after a lowercase letter. After displaying each record, it will ask the user 
"Do you want to fix this record (y/n)?" If the user answers "y", the program 
will remove trailing spaces, leading spaces and duplicated spaces and turn the 
text lo lowercase, except for the first letter and the ones after a dot, only 
in the title.

X - eXit the application (as we do not store the information on file, data will 
be lost). 
*/

using System;
using System.Text;

struct book
{
    public string title;
    public string author;
    public short yearPublished;
}

public class BooksCollection
{
    public static void Main()
    {
        const int MAX_BOOKS = 25000;
        book[] books = new book[MAX_BOOKS];

        int currentPos = 0;
        string option;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1.Add book");
            Console.WriteLine("2.Show books");
            Console.WriteLine("3.Search book by title/author.");
            Console.WriteLine("4.Search book by date.");
            Console.WriteLine("5.Update book.");
            Console.WriteLine("6.Delete book.");
            Console.WriteLine("7.Correct spelling in the titles.");
            Console.WriteLine("X.Exit");

            option = Console.ReadLine().ToLower();

            switch (option)
            {
                //Add a book
                case "1":
                    if (currentPos >= MAX_BOOKS)
                    {
                        Console.WriteLine("The database is full.");
                    }
                    else
                    {
                        Console.WriteLine("Book {0}:", currentPos + 1);

                        do
                        {
                            Console.Write("Enter the title: ");
                            books[currentPos].title = Console.ReadLine();
                            if (books[currentPos].title == "")
                            {
                                Console.WriteLine("Title can't be empty.");
                            }
                        } while (books[currentPos].title == "");

                        do
                        {
                            Console.Write("Enter the author: ");
                            books[currentPos].author = Console.ReadLine();
                            if (books[currentPos].author == "")
                            {
                                Console.WriteLine("Author can't be empty.");
                            }
                        } while (books[currentPos].author == "");

                        Console.Write("Enter the year in which " +
                            "it was published: ");
                        string year = Console.ReadLine();
                        if (year != "")
                        {
                            books[currentPos].yearPublished =
                                Convert.ToInt16(year);
                        }
                        else
                            books[currentPos].yearPublished = -1;

                        currentPos++;

                        //Sort
                        for (int i = 0; i < currentPos - 1; i++)
                        {
                            for (int j = i + 1; j < currentPos; j++)
                            {
                                if ((String.Compare(books[i].title,
                                    books[j].title, true) > 0)
                                    ||
                                    ((books[i].title == books[j].title)
                                        && (String.Compare(books[i].author,
                                        books[j].author, true) > 0)))
                                {
                                    book bookAux = books[i];
                                    books[i] = books[j];
                                    books[j] = bookAux;
                                }
                            }
                        }
                    }
                    break;

                //Show books
                case "2":
                    for (int i = 0; i < currentPos; i++)
                    {
                        Console.WriteLine("Book {0}", i + 1);
                        Console.WriteLine("Title: {0}", books[i].title);
                        Console.WriteLine("Author: {0}", books[i].author);
                        if (books[i].yearPublished == -1)
                            Console.WriteLine("Year: Unknown year");
                        else
                            Console.WriteLine("Year: {0}",
                                books[i].yearPublished);

                        Console.WriteLine();
                        if (i % 21 == 20)
                            Console.ReadLine();
                    }

                    break;

                //Search book by title/author
                case "3":
                    bool textFound = false;
                    Console.Write("Enter the keywords: ");
                    string search = Console.ReadLine().ToLower();
                    for (int i = 0; i < currentPos; i++)
                    {
                        if (books[i].title.ToLower().Contains(search)
                            || books[i].author.ToLower().Contains(search))
                        {
                            Console.WriteLine("Book {0}", i + 1);
                            Console.WriteLine("Title: {0}", books[i].title);
                            Console.WriteLine("Author: {0}", books[i].author);
                            if (books[i].yearPublished == -1)
                                Console.WriteLine("Year: Unknown year");
                            else
                                Console.WriteLine("Year: {0}",
                                    books[i].yearPublished);
                            textFound = true;

                            if (i % 21 == 20)
                                Console.ReadLine();
                        }
                        Console.WriteLine();
                    }
                    if (!textFound)
                        Console.WriteLine("Text not found");
                    break;

                //Seach book with two dates
                case "4":
                    bool dateFound = false;
                    Console.Write("Enter the first date: ");
                    short date1 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter the second date: ");
                    short date2 = Convert.ToInt16(Console.ReadLine());

                    // "date1" must be the lower date
                    if (date1 > date2)
                    {
                        short dateAux = date1;
                        date1 = date2;
                        date2 = dateAux;
                    }

                    for (int i = 0; i < currentPos; i++)
                    {
                        if (books[i].yearPublished >= date1 &&
                            books[i].yearPublished <= date2)
                        {
                            Console.WriteLine("Book {0}", i + 1);
                            Console.WriteLine("Title: {0}", books[i].title);
                            Console.WriteLine("Author: {0}", books[i].author);
                            Console.WriteLine("Year: {0}",
                                books[i].yearPublished);
                            Console.WriteLine();
                            dateFound = true;
                        }
                    }
                    if (!dateFound)
                        Console.WriteLine("Date not found");

                    break;

                //Update book/record
                case "5":
                    Console.Write("Enter the record num: ");
                    int recordPos = Convert.ToInt32(Console.ReadLine());
                    recordPos--;

                    if (recordPos < 0 || recordPos >= currentPos)
                    {
                        Console.WriteLine("Invalid number");
                    }
                    else
                    {
                        string answer;

                        Console.WriteLine("Book {0}", recordPos + 1);

                        //Title
                        Console.WriteLine("The title was: {0}",
                            books[recordPos].title);
                        Console.Write("Enter the new title: ");
                        answer = Console.ReadLine().TrimStart().TrimEnd();
                        if (answer != "")
                            books[recordPos].title = answer;


                        //Author
                        Console.WriteLine("The author was: {0}",
                            books[recordPos].author);
                        Console.Write("Enter the new author: ");
                        answer = Console.ReadLine().TrimStart().TrimEnd();
                        if (answer != "")
                            books[recordPos].author = answer;


                        //Year
                        if (books[recordPos].yearPublished == -1)
                            Console.WriteLine("The year was: Unknown year");
                        else
                            Console.WriteLine("the year was: {0}",
                                books[recordPos].yearPublished);
                        Console.Write("Enter the new year: ");
                        answer = Console.ReadLine().TrimStart().TrimEnd();
                        if (answer != "")
                            books[recordPos].yearPublished =
                                Convert.ToInt16(answer);

                        // Uppercase, Lowercase and redundant spaces
                        if (books[recordPos].title
                                == books[recordPos].title.ToUpper())
                            Console.WriteLine("The title is completely uppercase");
                        else if (books[recordPos].title
                                == books[recordPos].title.ToLower())
                            Console.WriteLine("The title is completely lowercase");
                        if (books[recordPos].title.Contains("  "))
                            Console.WriteLine("The title contains redundant spaces.");

                        if (books[recordPos].author
                                == books[recordPos].author.ToUpper())
                            Console.WriteLine("The author is completely uppercase");
                        else if (books[recordPos].author
                                == books[recordPos].author.ToLower())
                            Console.WriteLine("The author is completely lowercase");
                        if (books[recordPos].author.Contains("  "))
                            Console.WriteLine("The author contains redundant spaces.");
                    }

                    break;

                //Delete book
                case "6":
                    Console.Write("Enter the record num: ");
                    int bookPos = Convert.ToInt32(Console.ReadLine());
                    bookPos--;

                    if (bookPos < 0 || bookPos >= currentPos)
                    {
                        Console.WriteLine("Invalid number");
                    }
                    else
                    {
                        Console.WriteLine("Book {0}", bookPos + 1);
                        Console.WriteLine("Title: {0}", books[bookPos].title);
                        Console.WriteLine("Author: {0}", books[bookPos].author);
                        if (books[bookPos].yearPublished == -1)
                            Console.WriteLine("Year: Unknown year");
                        else
                            Console.WriteLine("Pages: {0}",
                                books[bookPos].yearPublished);

                        Console.Write("Delete this book (y/n)? ");
                        string answer = Console.ReadLine().ToLower();

                        if (answer == "y")
                        {
                            for (int i = bookPos; i < currentPos - 1; i++)
                            {
                                books[i] = books[i + 1];
                            }
                            Console.WriteLine("Successfully removed");
                            currentPos--;
                        }
                    }

                    break;

                // Show books with incorrect spelling and correct them
                case "7":
                    bool mustBeDisplayed;

                    for (int i = 0; i < currentPos; i++)
                    {
                        StringBuilder sb;
                        mustBeDisplayed = false;

                        // Uppercase rigth after a lowercase
                        string t = books[i].title;

                        for (int j = 0; j < t.Length - 1; j++)
                        {
                            if (t.Substring(j, 1)
                                    == t.Substring(j, 1).ToLower()
                                    && t.Substring(j + 1, 1)
                                    == t.Substring(j + 1, 1).ToUpper())
                                mustBeDisplayed = true;
                        }

                        //Consecutive spaces
                        if (books[i].title.Contains("  "))
                            mustBeDisplayed = true;

                        //Leading and trailing spaces
                        if (books[i].title[0] == ' ' ||
                                books[i].title[books[i].title.Length - 1]
                                    == ' ')
                            mustBeDisplayed = true;

                        //Display incorrect record
                        if (mustBeDisplayed)
                        {
                            Console.WriteLine("Book {0}", i + 1);
                            Console.WriteLine("Title: {0}", books[i].title);
                            Console.WriteLine("Author: {0}", books[i].author);
                            if (books[i].yearPublished == -1)
                                Console.WriteLine("Year: Unknown year");
                            else
                                Console.WriteLine("Pages: {0}",
                                    books[i].yearPublished);

                            //Fix record
                            Console.Write("Do you want to fix this record (y/n)? ");
                            if (Console.ReadLine() == "y")
                            {
                                //Delete consecutive spaces
                                while (books[i].title.Contains("  "))
                                    books[i].title =
                                    books[i].title.Replace("  ", " ");

                                //Delete leading or trailing spaces
                                books[i].title = books[i].title.Trim();

                                //First letter to uppercase and the ones after a dot
                                sb = new StringBuilder(books[i].title.ToLower());
                                // First letter is easy
                                sb[0] = Char.ToUpper(sb[0]);
                                // After the dot is not so easy...
                                for (int j = 1; j < sb.Length - 1; j++)
                                {
                                    // Is there a space after the stop?
                                    if (sb[j + 1] == ' ')
                                    {
                                        if (j < sb.Length - 2)
                                            sb[j + 2] = Char.ToUpper(sb[j + 2]);
                                    }
                                    else // Or is there a letter after the stop?
                                        sb[j + 1] -= Char.ToUpper(sb[j + 1]);
                                }
                                books[i].title = sb.ToString();
                                Console.WriteLine("Record fixed.");
                            }
                        }
                    }

                    break;

                case "x":
                    Console.WriteLine("Bye!");
                    break;

                default:
                    Console.WriteLine("Unknown option");
                    break;
            }

        } while (option != "x");
    }
}
