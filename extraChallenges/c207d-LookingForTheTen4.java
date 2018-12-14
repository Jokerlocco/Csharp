// Adrián Navarro Gabino

import java.util.*;

public class LookingForTheTen
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);        
        String[] marks = sc.nextLine().split(",");
        int denominator = marks.length;
        int sum = 0;
        
        for(int i = 0; i < denominator; i++)
        {
            sum += Integer.parseInt(marks[i]);
        }
        double currentAverage = (double)sum / denominator;
        
        if(currentAverage >= 9.5)
        {
            System.out.println(0);
        }
        else
        {
            int tasks = 19 * denominator - 2 * sum;
            System.out.println(tasks);
        }
    }
}
