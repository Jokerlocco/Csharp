/*
Create a C# program that can store up to 10000 expenses and incomes, to create 
a small domestic accounting system. For each expense (or income), you must 
allow the following data to be stored:

- Date (8 characters: YYYYMMDD format)
- Description of expense or income
- Category
- Amount (positive if it is an income, negative if it is an expense)

The program must allow the user to perform the following operations:

1- Add a new expense (the date must "seem correct": day from 01 to 31, month 
   from 01 to 12, year between 1000 and 3000). The description must not be
   empty. It is not necessary to validate the other data.

2- Show all the expenses of a certain category (for example, "studies") between 
   two certain dates (for example between "20110101" and "20111231"). You must 
   show number, date (in YY/MM/DDDD format), description, category in 
   parentheses, and amount with two decimal places, all in the same line, 
   separated by dashes. At the end of all the data, the total amount of the 
   displayed data will be displayed.

3- Search for expenses that contain a certain text (in the description or in 
   the category, not case sensitive). The number, date and description will be 
   shown (the description will be truncated in the sixth blank space, if there 
   are six spaces or more).

4- Modify a record (it will ask for the user's file number, the previous value of 
   each field will be shown and you can press Enter to not modify any of the 
   data).The user must be warned (but not asked again) if they enter an incorrect 
   card number.

5- Delete a certain record, whose number will entered by the user. You must warn 
   them (but not ask again) if they enter an incorrect number. The record to be 
   deleted must be displayed and the user must be asked for confirmation before
   proceeding with the deletion.

6- Sort the data alphabetically, according to date and (if necessary) description

7- Normalize descriptions: eliminate trailing spaces, leading spaces and 
   duplicate spaces. If any description is fully capitalized, it will be 
   converted to lowercase (except the first letter, which will be kept 
   uppercase).

T- Finish (as we do not know how to store the information, data will be lost).

*/

//Kevin Marín Romero

using System;
using System.Text;

public class DomesticAccounting
{
    struct ExpensesIncome
    {
        public string date;
        public string description;
        public string category;
        public float amount;
    }

    public static void Main()
    {
        const int SIZE = 1000;
        int total = 0;
        ExpensesIncome[] e = new ExpensesIncome[SIZE];
        string[] options = {"Add new Expense",
            "Show records for category and dates","Search Expense",
            "Modify registry","Delete registry","Sort records",
            "Normalize descriptions"};
        char option;

        do
        {
            Console.WriteLine("MENU");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, options[i]);
            }
            Console.WriteLine("T. Exit");
            Console.Write("Select Option: ");
            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case 'T':
                    Console.WriteLine("Good Bye!!!");
                    break;

                case '1':  // Add
                    if (total > SIZE)
                    {
                        Console.WriteLine("Data base full");
                    }
                    else
                    {
                        Console.Write("Enter the date for expense {0} : ",
                            total + 1);
                        string date = Console.ReadLine();
                        while ((Convert.ToInt32(date.Substring(0, 4)) < 1000 ||
                            Convert.ToInt32(date.Substring(0, 4)) > 3000) ||
                            (Convert.ToInt32(date.Substring(4, 2)) < 1 ||
                            Convert.ToInt32(date.Substring(4, 2)) > 12) ||
                            Convert.ToInt32(date.Substring(6, 2)) < 1 ||
                            Convert.ToInt32(date.Substring(6, 2)) > 31)
                        {
                            Console.Write("Enter the date for " +
                                "the expense {0} again: ", total + 1);
                            date = Console.ReadLine();
                        }
                        e[total].date = date;

                        Console.Write("Enter the description for {0} " +
                            "expense: ", total + 1);
                        string description = Console.ReadLine();
                        while (description == "")
                        {
                            Console.Write("Enter the description for {0} " +
                            "expense again: ");
                            description = Console.ReadLine();
                        }
                        e[total].description = description;

                        Console.Write("Enter the category for {0} " +
                        "expense: ", total + 1);
                        e[total].category = Console.ReadLine();

                        Console.Write("Enter the amount for {0} " +
                        "expense: ", total + 1);
                        e[total].amount = Convert.ToSingle(Console.ReadLine());
                        total++;
                    }
                    break;

                case '2':  // Show data of a category
                    Console.Write("Enter the category to search: ");
                    string category = Console.ReadLine().ToUpper();
                    Console.Write("Enter the first date: ");
                    string firstDate = Console.ReadLine();
                    Console.Write("Enter the second date: ");
                    string secondDate = Console.ReadLine();
                    Console.WriteLine();
                    bool isFound = false;
                    float sumAmount = 0;
                    for (int i = 0; i < total; i++)
                    {
                        if (e[i].category.ToUpper() == category &&
                            e[i].date.CompareTo(firstDate) >= 0 &&
                            e[i].date.CompareTo(secondDate) <= 0)
                        {
                            isFound = true;
                            Console.WriteLine("Registry {0}.-{1}/{2}/{3}-{4}-({5})-{6}",
                                i + 1, e[i].date.Substring(6, 2),
                                e[i].date.Substring(4, 2),
                                e[i].date.Substring(0, 4), e[i].description,
                                e[i].category, e[i].amount.ToString("0.00"));
                            sumAmount += e[i].amount;
                        }
                    }
                    if (isFound)
                        Console.WriteLine("\nTotal: {0}", sumAmount.ToString("0.00"));
                    else
                        Console.WriteLine("There aren't coincidences");

                    break;

                case '3': // Search text in description and category
                    Console.Write("Enter the text to search: ");
                    string text = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    bool isLocated = false;
                    byte spaces = 0;
                    for (int i = 0; i < total; i++)
                    {
                        if (e[i].description.ToUpper().Contains(text) ||
                            e[i].category.ToUpper().Contains(text))
                        {
                            isLocated = true;
                            int j = 0;
                            while (j < e[i].description.Length && spaces < 6)
                            {
                                if (e[i].description[j] == ' ')
                                {
                                    spaces++;
                                }
                                j++;
                            }
                            Console.WriteLine("Registry {0}.-{1}/{2}/{3}-{4}", i + 1,
                                e[i].date.Substring(6, 2),
                                e[i].date.Substring(4, 2),
                                e[i].date.Substring(0, 4),
                                spaces == 6 ? e[i].description.Substring(0, j - 1) :
                                    e[i].description);
                        }
                    }
                    if (!isLocated)
                        Console.WriteLine("There aren't coincidences");
                    break;

                case '4': // Edit
                    Console.Write("Enter the number of record to modify: ");
                    int modify = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (modify < 0 || modify > total - 1)
                    {
                        Console.WriteLine("Number of record incorrect");
                    }
                    else
                    {
                        Console.WriteLine("Record {0}:", modify + 1);
                        Console.WriteLine("New Date was({0}/{1}/{2}): ",
                            e[modify].date.Substring(6, 2),
                            e[modify].date.Substring(4, 2),
                            e[modify].date.Substring(0, 4));
                        string newDate = Console.ReadLine();

                        if (newDate != "")
                            e[modify].date = newDate;

                        Console.WriteLine("New description was ({0}):",
                            e[modify].description);
                        string newDecription = Console.ReadLine();

                        if (newDecription != "")
                            e[modify].description = newDecription;

                        Console.WriteLine("New category was ({0}):",
                            e[modify].category);
                        string newCategory = Console.ReadLine();

                        if (newCategory != "")
                            e[modify].category = newCategory;

                        Console.WriteLine("New amount was ({0}): ",
                            e[modify].amount);
                        string newAmount = Console.ReadLine();

                        if (newAmount != "")
                            e[modify].amount = Convert.ToSingle(newAmount);
                    }
                    break;

                case '5': // Delete
                    Console.Write("Enter the number of record to delete: ");
                    int delete = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (delete < 0 || delete > total - 1)
                    {
                        Console.WriteLine("Number of record incorrect");
                    }
                    else
                    {
                        Console.WriteLine("Record {0}:", delete + 1);
                        Console.WriteLine("Date: {0}/{1}/{2}",
                            e[delete].date.Substring(6, 2),
                            e[delete].date.Substring(4, 2),
                            e[delete].date.Substring(0, 4));
                        Console.WriteLine("Description: {0}",
                            e[delete].description);
                        Console.WriteLine("Category: {0}",
                            e[delete].category);
                        Console.WriteLine("Amount: {0}",
                            e[delete].amount);

                        Console.WriteLine("Are you sure you want to " +
                                    "eliminate the registry?(Y/N): ");
                        char secure = Char.ToUpper(Convert.ToChar(
                            Console.ReadLine()));
                        if (secure == 'Y')
                        {
                            for (int i = delete; i < total; i++)
                            {
                                e[i] = e[i + 1];
                            }
                            total--;
                            Console.WriteLine("Delete is completed");
                        }
                        else
                            Console.WriteLine(
                                        "The registry hasen't been deleted");
                    }
                    break;

                case '6': // Sort
                    for (int i = 1; i < total; i++)
                    {
                        int j = i - 1;
                        while ((j >= 0) && (
                        (String.Compare(e[j].date, e[j + 1].date, true) > 0) ||
                        (String.Compare(e[j].date, e[j + 1].date, true) == 0) &&
                        (String.Compare(e[j].description, e[j + 1].description,
                            true) > 0)))
                        {
                            ExpensesIncome aux = e[j];
                            e[j] = e[j + 1];
                            e[j + 1] = aux;
                            j--;
                        }
                    }
                    Console.WriteLine("Sorted satisfactorily");
                    break;

                case '7': // Normalize descriptions
                    if (total > SIZE)
                    {
                        Console.WriteLine("No records found");
                    }
                    else
                    {
                        for (int i = 0; i < total; i++)
                        {
                            e[i].description = e[i].description.Trim();
                            while (e[i].description.Contains("  "))
                            {
                                e[i].description = e[i].description.Replace(
                                    "  ", " ");
                            }

                            if (e[i].description == e[i].description.ToUpper()
                            {
                                e[i].description = e[i].description.ToLower();
                                StringBuilder description = new StringBuilder(
                                    e[i].description);
                                description[0] = Char.ToUpper(description[0]);
                                e[i].description = Convert.ToString(
                                    description);
                            }
                        }
                        Console.WriteLine("Descriptions are normalized");
                    }

                    break;
                default: Console.WriteLine("Unknown option"); break;
            }
            Console.WriteLine();
        } while (option != 'T');

    }
}
