// List + Menu (1)

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
