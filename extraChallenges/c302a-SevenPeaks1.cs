//Kevin Marín Romero
//Seven Peaks

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

public class SevenPeaks
{
    public static void Main()
    {
        ushort totalHeights;
        
        do
        {
            totalHeights = Convert.ToUInt16(Console.ReadLine());
            
            if (totalHeights != 0)
            {
                string[] data = Console.ReadLine().Split();
                ushort[] heights = new ushort[data.Length];
                int totalPeaks = 0;
                
                for (int i = 0; i < data.Length; i++)
                {
                    heights[i] = Convert.ToUInt16(data[i]);
                }
                
                if (heights[0] > heights[heights.Length-1] && 
                    heights[0] > heights[1])
                {
                    totalPeaks++;
                }
                
                for (int i = 1; i < heights.Length-1; i++)
                {
                    if (heights[i] > heights[i+1] && 
                    heights[i] > heights[i-1])
                    {
                        totalPeaks++;
                    }
                }
                
                if (heights[heights.Length-1] > heights[heights.Length-2] && 
                    heights[heights.Length-1] > heights[0])
                {
                    totalPeaks++;
                }
                
                Console.WriteLine(totalPeaks);
            }
            
        }while(totalHeights != 0);
    }
}
