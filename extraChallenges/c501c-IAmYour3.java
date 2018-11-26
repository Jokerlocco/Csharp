// Adrián Navarro Gabino

import java.util.*;

public class IAmYour
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        int cases = sc.nextInt();
        
        for(int i = 0; i < cases; i++)
        {
            String name = sc.next();
            String relationship = sc.next();
            
            if(name.equals("Luke") == false ||
                relationship.equals("padre") == false)
            {
                System.out.println(name + ", yo soy tu " + relationship);
            }
            else
            {
                System.out.println("TOP SECRET");
            }
        }
    }
}
