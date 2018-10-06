// Right-aligned Triangle

using System;

public class RightAlignedTriangle
{
    public static void Main()
    {
        int size;

        Console.Write("Enter the size: ");
        size = Convert.ToInt32(Console.ReadLine());

        int spaces = size - 1;
        int asterisks = 1;

        // Several rows
        for (int row = 1; row <= size; row++)
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
            asterisks++;
        }
    }
}
