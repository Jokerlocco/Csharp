/*
Laptops

One day Dima and Alex had an argument about the price and quality of laptops. 
Dima thinks that the more expensive a laptop is, the better it is. Alex 
disagrees. Alex thinks that there are two laptops, such that the price of the 
first laptop is less (strictly smaller) than the price of the second laptop but 
the quality of the first laptop is higher (strictly greater) than the quality 
of the second laptop.

Please, check the guess of Alex. You are given descriptions of n laptops. 
Determine whether two described above laptops exist.

Input
The first line contains an integer n (1 ≤ n ≤ 105) — the number of laptops.

Next n lines contain two integers each, ai and bi (1 ≤ ai, bi ≤ n), where ai is 
the price of the i-th laptop, and bi is the number that represents the quality 
of the i-th laptop (the larger the number is, the higher is the quality).

All ai are distinct. All bi are distinct.

Output

If Alex is correct, print "Happy Alex", otherwise print "Poor Alex" (without 
the quotes).

Examples

input1
2
1 2
2 1

output1
Happy Alex

---

input2
2
2 1
1 2

output2
Happy Alex

---

input3
3
2000 2
1000 1
3000 3

output3
Poor Alex

---

(Codeforces, problem 456A: https://codeforces.com/problemset/problem/456/A)
*/

// Adrián Navarro Gabino

using System;

class Laptops
{
    static bool IsHappy(int[,] laptops, int numberOfLaptops)
    {
        for(int i = 0; i < numberOfLaptops; i++)
            for(int j = 0; j < numberOfLaptops; j++)
                if(laptops[i,0] < laptops[j,0] && laptops[i,1] > laptops[j,1])
                    return true;
                    
        return false;
    }
    
    
    static void Main()
    {
        int numberOfLaptops = Convert.ToInt32(Console.ReadLine());
        
        int[,] laptops = new int[numberOfLaptops, 2];
        
        for(int i = 0; i < numberOfLaptops; i++)
        {
            string[] laptopAux = Console.ReadLine().Split();
            
            laptops[i, 0] = Convert.ToInt32(laptopAux[0]);
            laptops[i, 1] = Convert.ToInt32(laptopAux[1]);
        }
        
        if(IsHappy(laptops, numberOfLaptops))
            Console.WriteLine("Happy Alex");
        else
            Console.WriteLine("Poor Alex");
    }
}
