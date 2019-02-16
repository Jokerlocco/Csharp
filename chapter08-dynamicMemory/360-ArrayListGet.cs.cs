//Jaime Francisco Rebollo Domínguez

using System;
using System.Collections;

public class ArrayListListas
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        string data;
        Console.WriteLine("Enter data (empty to finish)");
        do
        {
            data = Console.ReadLine();

            if (data != "")
                list.Add(Convert.ToInt32(data));

        } while (data != "");

        int posToDisplay;
        do
        {
            Console.Write("Which position do you want to see (0 to finish)? ");
            posToDisplay = Convert.ToInt32(Console.ReadLine());
            if (posToDisplay != 0)
            {
                if (posToDisplay <= list.Count)
                {
                    int d = (int) list[posToDisplay - 1];
                    Console.WriteLine(d);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Position not found");
                }
            }
        } while (posToDisplay != 0);
    }
}
