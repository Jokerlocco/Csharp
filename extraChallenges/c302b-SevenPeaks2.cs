// Jorge Calzada Asenjo

/*
    Calculate the number of peaks on a roller coaster by knowing that a
    peak is that point on the route that is higher than the immediately
    preceding and immediately following and taking into account that
    the roller coaster is circular.
*/

/*
Input sample

4
4 10 3 2
4
10 3 2 4
5
4 10 10 3 2
5
1 10 1 10 1
5
10 1 10 1 10
6
10 1 10 1 10 1
6
1 10 1 10 1 10
0

Output Sample

1
1
0
2
1
3
3
*/

using System;

class SevenPeaks
{
    static void Main()
    {
        int heightsOnCourse;

        heightsOnCourse = Convert.ToInt32(Console.ReadLine());

        while (heightsOnCourse != 0)
        {
            int count = 0;

            int[] heights = Array.ConvertAll(Console.ReadLine().Split(),
                                             int.Parse);

            for (int i = 0; i < heightsOnCourse; i++)
            {
                int previous = (i - 1) == -1 ? heightsOnCourse - 1 : i - 1;
                int posterior = (i + 1) == heightsOnCourse ? 0 : i + 1;

                if (heights[i] > heights[previous] &&
                    heights[i] > heights[posterior])
                    count++;
            }

            Console.WriteLine(count);

            heightsOnCourse = Convert.ToInt32(Console.ReadLine());
        }
    }
}
