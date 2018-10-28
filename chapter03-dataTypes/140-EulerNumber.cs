// Jaime Francisco Rebollo Domínguez
// Estimation of Euler's number

using System;

public class E
{
    public static void Main()
    {
        string answer;
        double e, multiplier, previousE;
        int terms;
        
        do
        {
            Console.Write("Terms? ");
            answer = Console.ReadLine();
            if(answer != "")
            {
                terms = Convert.ToInt32(answer);
                e = 0;
                previousE = 0;
                if(terms != 0)
                {
                    e++;
                    multiplier = 1;
                    for(int i = 1; i < terms; i++)
                    {
                        previousE = e;
                        multiplier = multiplier * i;
                        e += 1/multiplier;
                    }
                }
                Console.WriteLine(
                    "e is approx {0} (difference with " + 
                    "{1} terms: {2})",
                    e, terms-1, e-previousE);
            }
        } while(answer != "");
        
        Console.WriteLine("Bye!");
    }
}
