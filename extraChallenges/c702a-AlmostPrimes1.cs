// Adrián Navarro Gabino

// Almost prime = two (not necessarily distinct) prime factors.
// How many almost prime numbers there are in certain integer intervals?

/*
Sample input

6
1 10
10 20
30000 40000
400000 500000
6000000 7000000
1 9999999

Sample output

4
3
2329
20773
185657
1904324
*/

using System;

public class AlmostPrimes
{
    public static bool IsAlmostPrime(int number)
    {
        for(int i = 2; i <= Math.Sqrt(number); i++)
            if(number % i == 0 && IsPrime(i))
                if(IsPrime(number / i))
                    return true;
        
        return false;
    }
    
    public static bool IsPrime(int number)
    {
        for(int i = 2; i <= Math.Sqrt(number); i++)
        {
            if(number % i == 0)
                return false;
        }
        
        return true;
    }
    
    
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for(int currentCase = 0; currentCase < cases; currentCase++)
        {
            string[] aux = Console.ReadLine().Split();
            
            int lowerLimit = Convert.ToInt32(aux[0]);
            int upperLimit = Convert.ToInt32(aux[1]);
            
            int count = 0;
            
            for(int i = lowerLimit; i <= upperLimit; i++)
            {
                if(IsAlmostPrime(i))
                    count++;
            }
            
            Console.WriteLine(count);
        }
    }
}
