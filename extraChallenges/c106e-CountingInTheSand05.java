// Adrián Navarro Gabino
// Challenge 1.06 - Counting in the sand (acepta 369)

/*
Counting in base 1

Example input
1
4
6
0

Example output
1
1111
111111
*/


import java.util.*;

public class Base1
{
    public static void main(String[] args)
    {
        int n;
        
        Scanner entrada = new Scanner(System.in);
        
        do
        {
            n = entrada.nextInt();

            if (n != 0)
            {
                for(int i = 0; i < n; i++)
                    System.out.print(1);
                System.out.println();
            }
        } while(n != 0);
    }
}
