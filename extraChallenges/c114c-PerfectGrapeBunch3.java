// Adrián Navarro Gabino

import java.util.*;

public class BunchesOfGrapes
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        int grapes;
        
        do
        {
            grapes = sc.nextInt();
            
            if(grapes != 0)
            {
                double level = (-1 + Math.sqrt(1 + 8 * grapes)) / 2;
                
                System.out.println((int)Math.ceil(level));
            }
        }while(grapes != 0);
    }
}
