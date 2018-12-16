// Adrián Navarro Gabino
// Seven peaks

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
        int numberOfTurningPoints;
        int numberOfPeaks;
        
        do
        {
            numberOfTurningPoints = Convert.ToInt32(Console.ReadLine());
            
            if(numberOfTurningPoints != 0)
            {
                numberOfPeaks = 0;
                
                int[] turningPoints = new int[numberOfTurningPoints + 2];
                
                string[] aux = Console.ReadLine().Split();
                
                for(int i = 0; i < numberOfTurningPoints; i++)
                {
                    turningPoints[i] = Convert.ToInt32(aux[i]);
                }
                
                turningPoints[numberOfTurningPoints] = turningPoints[0];
                turningPoints[numberOfTurningPoints + 1] = turningPoints[1];
                
                for(int i = 1; i < numberOfTurningPoints + 1; i++)
                {
                    if(     turningPoints[i] > turningPoints[i - 1] &&
                            turningPoints[i + 1] < turningPoints[i])
                    {
                        numberOfPeaks++;
                    }
                }
                
                Console.WriteLine(numberOfPeaks);
            }
        } while(numberOfTurningPoints != 0);
    }
}
