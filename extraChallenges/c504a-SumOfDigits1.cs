//Kevin Marín Romero
//Sum of Digits

/*
Input sample
3433
64323
8
-1


Output sample
3 + 4 + 3 + 3 = 13
6 + 4 + 3 + 2 + 3 = 18
8 = 8
*/

using System;

public class SumOfDigits
{
    public static void Main()
    {
        string number;
        
        do
        {
            number = Console.ReadLine();
            
            if (number != "-1")
            {
                int sum = 0;
                string answer = "";
                
                for (int i = 0; i < number.Length-1; i++)
                {
                    sum += Convert.ToInt32(number.Substring(i,1));
                    answer += number[i] + " + ";
                }
                sum += Convert.ToInt32(number.Substring(number.Length-1));
                answer += number[number.Length-1];
                
                Console.WriteLine(answer + " = " + sum);
            }
            
        }while(number != "-1");
    }
}
