// Greatest digit of a long integer numbe
// Ivan Lazcano Sindin

using System;

public class EJ
{
    public static int GreatestDigit(long n)
    {
        string sn = n.ToString();
        char greatest = sn[0];
        foreach(char l in sn)
        {
            if (l > greatest)
                greatest = l;
        }

        return Convert.ToInt32(greatest-'0');
    }

    public static void Main()
    {
        Console.Write(GreatestDigit(32)); // Should display 3

        if (GreatestDigit(276) != 7)
            Console.WriteLine("Something is not right!");
    }
}
