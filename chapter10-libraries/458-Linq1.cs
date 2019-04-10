using System;
using System.Linq;

class LinqSorted
{
    public static void Main()
    {
        int[] nums = new int[10];
        for(int i = 0 ; i < 10 ; i++)
        {
            Console.Write("Number "+(i+1)+": ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        var result =
            from n in nums
            orderby n
            select n;
        
        foreach(int i in result)
        {
            Console.WriteLine(i);
        }
    }
}
