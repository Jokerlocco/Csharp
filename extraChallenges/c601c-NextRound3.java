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

import java.util.*;

public class NextRound
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        int players = sc.nextInt();
        int chosenPlayer = sc.nextInt();
        sc.nextLine();
        
        int[] score = new int[players];
        
        for(int i = 0; i < players; i++)
        {
            score[i] = sc.nextInt();
        }
        
        int count = 0;
        
        for(int s: score)
        {
            if(s >= score[chosenPlayer - 1] && s > 0)
                count++;
        }
        
        System.out.println(count);
    }
}
