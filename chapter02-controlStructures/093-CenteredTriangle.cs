// Centered Triangle

using System;

public class CenteredTriangle
{
    public static void Main()
    {
        int size;

        Console.Write("Enter the size of the base: ");
        size = Convert.ToInt32(Console.ReadLine());

        int spaces = size/2;
        int asterisks = size % 2 == 0 ? 2 : 1;
        int maxRow = size % 2 == 0 ? size/2 : size/2 + 1;

        // Several rows
        for (int row = 1; row <= maxRow; row++)
        {
            // Several spaces in each row
            for (int space = 1; space <= spaces; space++)
                Console.Write(" ");
            // Several asterisks in each row
            for (int asterisk = 1; asterisk <= asterisks; asterisk++)
                Console.Write("*");
            // And let's advance to the next line
            Console.WriteLine();
            spaces--;
            asterisks = asterisks + 2;
        }
    }
}
