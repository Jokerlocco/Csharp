// Victor Tebar
// LookingForTheTen

/*

Sample inputs

9,10,10,9
8,9
0,0,0,0,0,0,0,0,0,0,0,0,0
10,10,10,10
7,7,10,10,4,6,4,6,0,6,7,4,6,6,9

Outputs for those inputs

0
4
247
0
101

*/

using System;
using System.Linq;
using System.Globalization;

public class Challenge {
    public static void Main(string[] args){
        string[] data = Console.ReadLine().Split(',');
        double sum = data.Select
            (n => double.Parse(n,CultureInfo.InvariantCulture)).Sum();
            
        if(sum/data.Length >= 9.5)
            Console.WriteLine(0);
        else
            /* El ceiling esta por que no especifica en ningun momento 
               que solo se vayan a pasar enteros en las notas. */
            Console.WriteLine(Math.Ceiling((9.5 * data.Length - sum) * 2));
    }
}
