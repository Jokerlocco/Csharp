// Jorge Calzada

using System;

class HarshadNumber
{
    public static int SumDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    public static bool IsHarshadNumber(int num)
    {
        return num % SumDigits(num) == 0;
    }

    static void Main()
    {
        int num = 152;

        if (IsHarshadNumber(num))
        {
            Console.WriteLine("{0} is a Harshad number", num);
        }
        else
        {
            Console.WriteLine("{0} is not a Harshad number", num);
        }
    }
}
