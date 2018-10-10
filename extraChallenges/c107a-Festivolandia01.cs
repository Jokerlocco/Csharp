// Ruth martínez
// Challenge 1.07, Festivolandia
// "FESTIVO" if 23/12 or odd/odd or even/even
// else: "LABORABLE"

/*
Sample input
6
8
7
25
12
11
1
2
2
14
2
3
2

Sample output
LABORABLE
FESTIVO
FESTIVO
FESTIVO
FESTIVO
LABORABLE
*/

using System;

public class Festivolandia
{
    public static void Main()
    {
        int days, month, cases;

        cases = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            days=Convert.ToInt32(Console.ReadLine());
            month=Convert.ToInt32(Console.ReadLine());
            
            if ((days == 25) && (month == 12))
                    Console.WriteLine("FESTIVO");
                
            else if (((days % 2  == 0) && (month % 2 == 0)) 
                        || ((days % 2 == 1) && (month % 2 == 1)))
                    Console.WriteLine("FESTIVO");
                    
                else
                    Console.WriteLine("LABORABLE");
        }
    }   
}
