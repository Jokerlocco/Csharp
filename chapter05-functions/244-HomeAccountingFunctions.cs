// Home accounting (V2: functions)
// Kevin Marín Romero

using System;
using System.Text;

public class HomeAccounting
{
    public struct ExpensesIncome    
    {
        public string date;
        public string description;
        public string category;
        public float amount;
    }


    public static void AddExpense(ref int total, int SIZE, ExpensesIncome[] e)
    {
        if (total > SIZE)
        {
            Console.WriteLine("Data base full");
        }
        else
        {
            Console.Write("Enter the date for {0} expenditure: ",
                total + 1);
            string date = Console.ReadLine();
            while ((Convert.ToInt32(date.Substring(0, 4)) < 1000 ||
                Convert.ToInt32(date.Substring(0, 4)) > 3000) ||
                (Convert.ToInt32(date.Substring(4, 2)) < 1 ||
                Convert.ToInt32(date.Substring(4, 2)) > 12) ||
                Convert.ToInt32(date.Substring(6, 2)) < 1 ||
                Convert.ToInt32(date.Substring(6, 2)) > 31)
            {
                Console.Write("Enter the date for {0} " +
                    "the expenditure again: ", total + 1);
                date = Console.ReadLine();
            }
            e[total].date = date;

            Console.Write("Enter the description for {0} " +
                "expenditure: ", total + 1);
            string description = Console.ReadLine();
            while (description == "")
            {
                Console.Write("Enter the description for {0} " +
                "expenditure again: ");
                description = Console.ReadLine();
            }
            e[total].description = description;

            Console.Write("Enter the category for {0} " +
            "expenditure: ", total + 1);
            e[total].category = Console.ReadLine();

            Console.Write("Enter the amount for {0} " +
            "expenditure: ", total + 1);
            e[total].amount = Convert.ToSingle(Console.ReadLine());
            total++;
        }
    }


    public static void ShowRecords(int total, ExpensesIncome[] e)
    {
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
            if (e[i].category.ToUpper().Contains(category) &&
                e[i].date.CompareTo(firstDate) >= 0 &&
                e[i].date.CompareTo(secondDate) <= 0)
            {
                isFound = true;
                Console.WriteLine("Record {0}.-{1}/{2}/{3}-{4}-({5})-{6}",
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
    }


    public static void SearchExpense(int total, ExpensesIncome[] e)
    {
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
                Console.WriteLine("Record {0}.-{1}/{2}/{3}-{4}", i + 1,
                    e[i].date.Substring(6, 2),
                    e[i].date.Substring(4, 2),
                    e[i].date.Substring(0, 4),
                    spaces == 6 ? e[i].description.Substring(0, j - 1) :
                    e[i].description);
            }
        }
        if (!isLocated)
            Console.WriteLine("Not found");
    }


    public static void ModifyRecord(int total, ExpensesIncome[] e)
    {
        Console.Write("Enter the number of register to modify: ");
        int modify = Convert.ToInt32(Console.ReadLine()) - 1;
        if (modify < 0 || modify > total - 1)
        {
            Console.WriteLine("Number of register incorrect");
        }
        else
        {
            Console.WriteLine("Register {0}:", modify + 1);
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
    }


    public static void DeleteRecord(ref int total, ExpensesIncome[] e)
    {
        Console.Write("Enter the number of register to delete: ");
        int delete = Convert.ToInt32(Console.ReadLine()) - 1;

        if (delete < 0 || delete > total - 1)
        {
            Console.WriteLine("Number of register incorrect");
        }
        else
        {
            Console.WriteLine("Register {0}:", delete + 1);
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
                        "delete the record?(Y/N): ");
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
                            "The record hasn't been deleted");
        }
    }


    public static void SortRecord(int total, ExpensesIncome[] e)
    {
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
        Console.WriteLine("Sorted!");
    }


    public static void NormalizeDescriptions(int total, int SIZE, ExpensesIncome[] e)
    {
        if (total > SIZE)
        {
            Console.WriteLine("There aren't records");
        }
        else
        {
            for (int i = 0; i < total; i++)
            {
                while (e[i].description.Contains("  "))
                {
                    e[i].description = e[i].description.Replace(
                        "  ", " ");
                }
                e[i].description = e[i].description.Trim();
                if (e[i].description.CompareTo(
                    e[i].description.ToUpper()) == 0)
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
    }


    public static void Main()
    {
        const int SIZE = 1000;
        int total = 0;
        ExpensesIncome[] e = new ExpensesIncome[SIZE];
        string[] options = {"Add new Expense",
            "Show records for category and dates","Search Expense",
            "Modify record","Delete record","Sort records",
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
                case 'T': Console.WriteLine("Good Bye!!!"); break;
                case '1':
                    AddExpense(ref total, SIZE, e);
                    break;
                case '2':
                    ShowRecords(total, e);
                    break;
                case '3':
                    SearchExpense(total, e);
                    break;
                case '4':
                    ModifyRecord(total, e);
                    break;
                case '5':
                    DeleteRecord(ref total, e);
                    break;
                case '6':
                    SortRecord(total, e);
                    break;
                case '7':
                    NormalizeDescriptions(total, SIZE, e);
                    break;
                default: Console.WriteLine("Unknown option"); break;
            }
            Console.WriteLine();
        } while (option != 'T');

    }
}
