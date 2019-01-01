//Ivan Lazcano Sindin
using System;
public class EsEmirpPrograma
{
    public static bool EsPrimo(int n)
    {
        for (int i = 2; i < n/2; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
    
    public static bool EsEmirp(int n)
    {
        if(EsPrimo(n))
        {
            char[] array = n.ToString().ToCharArray();
            Array.Reverse(array);
            int n2 = Convert.ToInt32(new String(array));
            if ((n != n2) && (EsPrimo(n2)))
                return true;
        }
        return false;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(EsPrimo(17));
        Console.WriteLine(EsPrimo(13));
        Console.WriteLine(EsPrimo(37));
        Console.WriteLine(EsPrimo(79));
        Console.WriteLine(EsPrimo(12)); 
        Console.WriteLine(EsPrimo(40));
        Console.WriteLine(EsPrimo(7));
        
        // Extra: to test times
        // From 1 to 99999... 00:00:00.8367425 in i7 7700HQ
        bool debugging = true;
        if (debugging)
        {
            int first = 1;
            int last = 99999;
            Console.WriteLine("Measuring times from "+
                first+" to "+last +"...");
            int amount = 0;
            DateTime start = DateTime.Now;
            for(int i = first; i <= last; i++)
            {
                if(EsEmirp(i))
                    amount++;
            }
            Console.WriteLine("Time taken: "+ (DateTime.Now-start));
            Console.WriteLine("Found: "+ amount);
        }

    }
}
