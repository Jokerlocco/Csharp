// Adrián Navarro Gabino

/*
7.05 - Primacity (FBHC)

A prime is a positive integer greater than 1 that is divisible by only 1 and 
itself.

Primes seem fun, but let's define another term: primacity. The primacity of an 
integer is the number of distinct primes which divide it. For example, the 
primacity of 12 is 2 (as it's divisible by primes 2 and 3), the primacity of 
550 is 3 (as it's divisible by primes 2, 5, and 11), and the primacity of 7 is 
1 (as the only prime it's divisible by is 7).

Given 3 integers A, B, and K, how many integers in the inclusive range [A, B] 
have a primacity of exactly K?

Input

Input begins with an integer T, the number of questions. For each question, 
there is one line containing 3 space-separated integers: A, B, and K.

Output

For the ith question, print a line containing "Case #i: " followed by the 
number of integers in the inclusive range [A, B] with a primacity of K.

Constraints
1 <= T <= 100 
2 <= A <= B <= 10^7 
1 <= K <= 109

Explanation of Sample

In the first test case, the numbers in the inclusive range [5, 15] with 
primacity 2 are 6, 10, 12, 14, and 15. All other numbers in this range have 
primacity 1.

Example input
5
5 15 2
2 10 1
24 42 3
1000000 1000000 1
1000000 1000000 2

Example output

Case #1: 5
Case #2: 7
Case #3: 2
Case #4: 0
Case #5: 1

(Facebook Hackercup 2015, problem 1)
*/

using System;

class Primacity
{
    static bool IsPrime(int number)
    {
        for(int i = 2; i <= Math.Sqrt(number); i++)
        {
            if(number % i == 0)
                return false;
        }
        
        return true;
    }

    static bool HasKPrimes(int number, int k)
    {
        if(IsPrime(number))
        {
            if(k == 1)
                return true;
            else
                return false;
        }
        
        int primes = 0;
        
        for(int i = 2; i <= number / 2; i++)
        {
            if(number % i == 0 && IsPrime(i))
                primes++;
            
            if(primes > k)
                return false;
        }
        
        if(primes == k)
            return true;
        else
            return false;
    }
    
    
    static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for(int index = 1; index <= cases; index++)
        {
            string[] input = Console.ReadLine().Split();
            
            int count = 0;
            
            for(int i = Convert.ToInt32(input[0]);
                i <= Convert.ToInt32(input[1]);
                i++)
            {
                if(HasKPrimes(i, Convert.ToInt32(input[2])))
                    count++;
            }
            
            Console.WriteLine("Case #{0}: {1}", index, count);
        }
    }
}
