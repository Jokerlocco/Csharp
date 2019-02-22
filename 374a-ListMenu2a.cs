// María González Martínez
// List + Menu (2)

using System;
using System.Collections.Generic;

class ListAndMenu
{
    static void Main()
    {
        List<string> data = new List<string>();
        string option;

        do
        {
            Console.WriteLine();
            Console.WriteLine("A - Add");
            Console.WriteLine("V - View all");
            Console.WriteLine("F - Find");
            Console.WriteLine("I - Insert");
            Console.WriteLine("E - Delete");
            Console.WriteLine("M - Modify");
            Console.WriteLine("O - Order");
            Console.WriteLine("Q - Quit");

            option = Console.ReadLine().ToUpper();
            switch (option)
            {
                case "A":
                    Console.Write("Enter some text to add: ");
                    data.Add(Console.ReadLine());
                    break;
                case "V":
                    foreach (string s in data)
                    {
                        Console.WriteLine(s);
                    }
                    break;
                case "F":
                    Console.Write("Which text do you want to find: ");
                    string search = Console.ReadLine();
                    bool found = false;
                    foreach (string s in data)
                    {
                        if (s.ToUpper().Contains(search.ToUpper()))
                        {
                            found = true;
                            Console.WriteLine(s);
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Not found!");
                    }
                    break;
                case "I":
                    Console.Write("In which position do you want to insert: ");
                    int insertPosition = Convert.ToInt32(Console.ReadLine())-1;
                    Console.Write("Which text do you want to insert: ");
                    string insert = Console.ReadLine();
                    data.Insert(insertPosition, insert);
                    break;
                case "D":
                    Console.Write("Which position do you want to delete: ");
                    int deletePosition = Convert.ToInt32(Console.ReadLine())-1;
                    data.RemoveAt(deletePosition);
                    break;
                case "M":
                    Console.Write("In which position do you want to modify: ");
                    int modifyPosition = Convert.ToInt32(Console.ReadLine())-1;
                    Console.Write("Which text do you want: ");
                    string modify = Console.ReadLine();
                    data[modifyPosition] = modify;
                    break;
                case "O":
                    data.Sort();
                    break;
                case "Q":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }
        while (option != "Q");
    }
}
