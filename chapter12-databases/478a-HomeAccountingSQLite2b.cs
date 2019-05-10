using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;

public class HomeAccounting
{
    public static void AddExpense()
    {
        Console.Write("Enter the date: ");
        string date = Console.ReadLine();
        while ((Convert.ToInt32(date.Substring(0, 4)) < 1000 ||
            Convert.ToInt32(date.Substring(0, 4)) > 3000) ||
            (Convert.ToInt32(date.Substring(4, 2)) < 1 ||
            Convert.ToInt32(date.Substring(4, 2)) > 12) ||
            Convert.ToInt32(date.Substring(6, 2)) < 1 ||
            Convert.ToInt32(date.Substring(6, 2)) > 31)
        {
            Console.Write("Enter the date again: ");
            date = Console.ReadLine();
        }

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();
        while (description == "")
        {
            Console.Write("Enter the description for {0} " +
            "expense again: ");
            description = Console.ReadLine();
        }

        Console.Write("Enter the category: ");
        string category = Console.ReadLine();

        Console.Write("Enter the amount: ");
        float amount = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        string command = "insert into home " +
                "values (" + id + ",'" +
                date + "','" +
                description + "','" +
                category + "'," +
                amount + ");";
        UpdateData(command);
    }


    public static void ShowRecords()
    {
        Console.Write("Enter the category to search: ");
        string category = Console.ReadLine().ToUpper();
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();
        Console.WriteLine();

        DisplayRecords("select * from home " +
                "where categoria = '" + category + "' " +
                "and fecha > '" + firstDate + "' " +
                "and fecha < '" + secondDate + "' " +
                "order by fecha, descripcion;");
    }


    public static void SearchExpense()
    {
        Console.Write("Enter the text to search: ");
        string text = Console.ReadLine().ToUpper();
        Console.WriteLine();

        DisplayRecords("select * from home " +
                "where descripcion like '%" + text + "%' " +
                "or categoria like '%" + text + "%' "
                +"order by fecha, descripcion;");
    }


    public static void ModifyRecord()
    {
        Console.Write("Enter the id of record to modify: ");
        int modify = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter new date (blank to leave as is): ");
        string newDate = Console.ReadLine();

        Console.WriteLine("New description (blank to leave as is):");
        string newDescr = Console.ReadLine();

        Console.WriteLine("New category (blank to leave as is):");
        string newCateg = Console.ReadLine();

        Console.WriteLine("New amount (blank to leave as is): ");
        string newAmount = Console.ReadLine();

        string command = "update home set id=" + modify;
        if (newDate != "")  command += ", fecha='" + newDate + "'";
        if (newDescr != "") command += ", descripcion='" + newDescr + "'";
        if (newCateg != "") command += ", categoria='" + newCateg + "'";
        if (newAmount != "") command += ", cantidad='" + newAmount;
        command += " where id = " + modify;
        UpdateData(command);
    }


    public static void DeleteRecord()
    {
        Console.Write("Enter the id of record to delete: ");
        int delete = Convert.ToInt32(Console.ReadLine());

        string command = "select * from home " +
                "where  id = " + delete + ";";
        List<string> data = GetData(command);
        if (data.Count == 0)
        {
            Console.WriteLine("Not found");
        }
        else
        {
            foreach (string s in data)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Are you sure you want to " +
                        "delete the record?(Y/N): ");
            char secure = Char.ToUpper(Convert.ToChar(
                Console.ReadLine()));
            if (secure == 'Y')
            {
                string deletionCommand = "delete from home " +
                    "where  id = " + delete + ";";
                UpdateData(deletionCommand);
            }
        }
    }


    public static void SortRecord()
    {
        Console.WriteLine("Sorted!");
    }


    public static void NormalizeDescriptions()
    {
        /*
        for (int i = 0; i < e.Count; i++)
        {
            ExpensesIncomes expenseNormalize = e[i];
            while (expenseNormalize.description.Contains("  "))
            {
                expenseNormalize.description = e[i].description.Replace(
                    "  ", " ");
            }
            expenseNormalize.description =
                expenseNormalize.description.Trim();
            if (expenseNormalize.description.CompareTo(
                expenseNormalize.description.ToUpper()) == 0)
            {
                expenseNormalize.description =
                    expenseNormalize.description.ToLower();
                StringBuilder description = new StringBuilder(
                    expenseNormalize.description);
                description[0] = Char.ToUpper(description[0]);
                expenseNormalize.description = Convert.ToString(
                    description);
            }
            e[i] = expenseNormalize;
        }

        Console.WriteLine("Descriptions are normalized");
        */
    }

    public static int UpdateData(string command)
    {
        if (!File.Exists("home.sqlite"))
            CreateTable();

        SQLiteConnection conn = new SQLiteConnection
             ("Data Source=home.sqlite;Version=3;New=True;Compress=True;");
        conn.Open();
        SQLiteCommand cmd = new SQLiteCommand(command, conn);
        int amount = cmd.ExecuteNonQuery();
        conn.Close();
        return amount;
    }

    public static void CreateTable()
    {
        SQLiteConnection conn = new SQLiteConnection
             ("Data Source=home.sqlite;Version=3;New=True;Compress=True;");
        conn.Open();
        string command = "create table home ("
           + "id int primary key, fecha varchar(30),descripcion varchar(50),"
           + "categoria varchar(25),cantidad int);";
        SQLiteCommand cmd = new SQLiteCommand(command, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public static List<string> GetData(string command)
    {
        List<string> result = new List<string>();
        SQLiteConnection conn = new SQLiteConnection
             ("Data Source=home.sqlite;Version=3;New=True;Compress=True;");
        conn.Open();
        SQLiteCommand cmd = new SQLiteCommand(command, conn);
        SQLiteDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            result.Add("Record: " +  reader[0]);
            result.Add("Date: " + reader[1]);
            result.Add("Description: " + reader[2]);
            result.Add("Category: " + reader[3]);
            result.Add("Amount: " + reader[4]);
            result.Add("");
        }

        return result;
    }


    public static void DisplayRecords(string sqlExpression)
    {
        List<string> data = GetData(sqlExpression);
        if (data.Count == 0)
        {
            Console.WriteLine("Not found");
        }
        else
        {
            foreach (string s in data)
            {
                Console.WriteLine(s);
            }
        }
    }

    public static void Main()
    {
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
                    AddExpense();
                    break;
                case '2':
                    ShowRecords();
                    break;
                case '3':
                    SearchExpense();
                    break;
                case '4':
                    ModifyRecord();
                    break;
                case '5':
                    DeleteRecord();
                    break;
                case '6':
                    SortRecord();
                    break;
                case '7':
                    NormalizeDescriptions();
                    break;
                default: Console.WriteLine("Unknown option"); break;
            }
            Console.WriteLine();
        } while (option != 'T');

    }
}
