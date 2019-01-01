// Nacho

// Almost prime = two (not necessarily distinct) prime factors.
// How many almost prime numbers there are in certain integer intervals?

// Time taken: 0:13.406 from 1 to 9999999 on Core i7 3630QM, 2.4 GHz

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
        DateTime start = DateTime.Now;
        const int MAX = 9999999;
        bool[] isPrime = new bool[MAX+1];
        bool[] isAlmostPrime = new bool[MAX+1];
        
        // First, let's calculate the prime numbers
        for (int i=2; i<=MAX; i++)
        {
            isPrime[i] = IsPrime(i);
        }
        
        // Then the almost prime numbers
        for (int i=2; i<=MAX; i++)
            for (int j=2; j<=MAX/i; j++)        
            {
                if (isPrime[i] && isPrime[j])
                    isAlmostPrime[i*j] = true;
            }
        
        // Now, le's test the speed
        bool debugging = true;
        if (debugging)
        {
            int first = 1;
            int last = 9999999;
            Console.WriteLine("Measuring times from "+
                first+" to "+last +"...");
            int amount = 0;
            
            for(int i = first; i <= last; i++)
            {
                if(isAlmostPrime[i])
                    amount++;
            }
            Console.WriteLine("Time taken: "+ (DateTime.Now-start));
            Console.WriteLine("Found: "+ amount);
        }

        // And let's proceed with the real challenge
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for(int currentCase = 0; currentCase < cases; currentCase++)
        {
            string[] aux = Console.ReadLine().Split();
            
            int lowerLimit = Convert.ToInt32(aux[0]);
            int upperLimit = Convert.ToInt32(aux[1]);
            
            int count = 0;
            
            for(int i = lowerLimit; i <= upperLimit; i++)
            {
                if(isAlmostPrime[i])
                    count++;
            }
            
            Console.WriteLine(count);
        }
    }
}
