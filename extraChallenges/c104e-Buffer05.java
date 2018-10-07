// Adrián Navarro Gabino

/*
How many men can use wall-mounted urinals at the same time without breaking
the rule that one must always leave a buffer between a urinal and other
urinal?
*/

/*
Example of entry:
5
1
2
3
4
5

Output for that example:
1
1
2
2
3
*/

import java.util.*;

public class BufferChallenge
{
    public static void main(String[] args)
    {
        int cases, urinals, numberOfMen;
        
        Scanner entrada = new Scanner(System.in);
        
        cases = entrada.nextInt();
        
        for(int i = 0; i < cases; i++)
        {
            urinals = entrada.nextInt();
            numberOfMen = urinals % 2 == 0 ? urinals / 2 : (urinals + 1) / 2;
            System.out.println(numberOfMen);
        }
    }
}
