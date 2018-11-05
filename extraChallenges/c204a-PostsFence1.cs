// Jorge Calzada Asenjo
// Challenge 2.04: Posts for a fence
// C# version

/*
Calculate the minimum number of posts needed to fence an area by
knowing how much it measures and how often a post needs to be placed.
*/

/*
Example of input
10 10 10
6 6 10
10 15 10
0 0 0

Example of output
4
4
6
*/

using System;

public class PostsFence
{
    public static void Main()
    {
        string data;
        int posts;

        data = Console.ReadLine();

        while (data != "0 0 0")
        {
           string[] stringmeasures = data.Split();
           int[] measures = { Convert.ToInt32(stringmeasures[0]), Convert.ToInt32(stringmeasures[1]), Convert.ToInt32(stringmeasures[2]) };

           posts = (measures[0] / measures[2] * 2) + (measures[1] / measures[2] * 2);

           posts += measures[0] % measures[2] != 0 ? 2 : 0;
           posts += measures[1] % measures[2] != 0 ? 2 : 0;

           posts = posts < 4 ? 4 : posts;

           Console.WriteLine(posts);

           data = Console.ReadLine();
        }
    }
}
