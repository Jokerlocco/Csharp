// Adrián Navarro Gabino
// Sum of Digits

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

import java.util.*;

public class SumOfDigits
{
    public static void main(String[] args)
    {
        String number;
        int digit;
        Scanner sc = new Scanner(System.in);
        
        do
        {
            int sum = 0;
            number = sc.nextLine();
            
            if(number.charAt(0) != '-')
            {
                for(int i = 0; i < number.length() - 1; i++)
                {
                    digit = Integer.parseInt("" + number.charAt(i));
                    sum += digit;
                    System.out.print(digit + " + ");
                }
                
                digit = Integer.parseInt("" + number.charAt(number.length() - 1));
                sum += digit;
                System.out.println(digit + " = " + sum);
            }
        } while(number.charAt(0) != '-');
    }
}
