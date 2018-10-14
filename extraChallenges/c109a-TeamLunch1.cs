// María González Martínez
// Challenge 1.09 - Team lunch (amount of 4-sided tables for n atendees)

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
public class TeamLunch
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        int tables;
        
        for(int t = 1 ; t <= cases ; t++ )
        {
            int atendees = Convert.ToInt32(Console.ReadLine());
            
            if(atendees <= 4)
                tables = 1;
            else if (atendees % 2 == 0)
                tables = atendees / 2 - 1;
            else 
                tables= atendees / 2;
            
            Console.WriteLine("Case #{0}: {1}",t,tables);
         }
    }
}
