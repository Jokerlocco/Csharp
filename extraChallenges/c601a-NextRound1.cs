// Adrián Navarro Gabino
// Next Round

/*
input 1
8 5
10 9 8 7 7 7 5 5

output 1
6

input 2
4 2
0 0 0 0
output 2
0
*/

using System;

public class NextRound
{
    public static void Main()
    {
        string[] aux = Console.ReadLine().Split();
        
        int players = Convert.ToInt32(aux[0]);
        int chosenPlayer = Convert.ToInt32(aux[1]);
        
        int[] score = new int[players];
        aux = Console.ReadLine().Split();
        
        for(int i = 0; i < players; i++)
        {
            score[i] = Convert.ToInt32(aux[i]);
        }
        
        int count = 0;
        
        foreach(int s in score)
        {
            if(s >= score[chosenPlayer - 1] && s > 0)
                count++;
        }
        
        Console.WriteLine(count);
    }
}
