// Jorge Calzada Asenjo
// Challenge 1.09 - Team lunch
// C# version

/*
    Calculate the number of tables needed for the team lunch
*/

/*
Sample input
6
4
6
5
3
26073
59794

Sample output
Case #1: 1
Case #2: 2
Case #3: 2
Case #4: 1
Case #5: 13036
Case #6: 29896
*/

using System;

public class TeamLunch1
{
    public static void Main()
    {
        int t, n;

        t = Convert.ToInt32(Console.ReadLine());

        for (int cases = 1; cases <= t; cases++)
        {
            n = Convert.ToInt32(Console.ReadLine());

            // Option 1
            Console.WriteLine("Case #{0}: {1}", cases,
                              (n < 5 && n > 0) ? 1 : (n - 1) / 2);

            // Option 2
            //int result = 0;
            //for (int i = (n < 5 && n > 0) ? 3 : n; i > 2; i -= 2)
            //    result++;
            //Console.WriteLine("Case #{0}: {1}", cases, result);
        }
    }
}
