// Manuel Lago

using System;

public class Emirp
{
    public static bool EsPrimo ( int num )
    {
        int divisores = 0;
        
        for(int i = 1; i <= num; i++)
        {
            if(num % i == 0)
                divisores++;
        }
        if (divisores == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public static bool EsEmirp ( int num )
    {
        int count = 0;
        
        if ( EsPrimo( num ) )
        {
            count++;
        }
        
        string textoNum = Convert.ToString( num );
        
        string invertir = "";
        
        for ( int i = textoNum.Length - 1 ; i >= 0 ; i-- )
        {
            invertir += textoNum[i];
        }
        
        int invNum = Convert.ToInt32( invertir );
        
        if ( EsPrimo ( invNum ) )
        {
            count++;
        }
        
        if ( count == 2 )
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public static void Main()
    {
        Console.WriteLine("Introduce un numero: ");
        int num = Convert.ToInt32( Console.ReadLine() );
        
        if ( EsEmirp( num ) )
        {
            Console.WriteLine("Es Emirp");
        }
        else
        {
           Console.WriteLine("No Es Emirp"); 
        }
        
        // Extra: to test times
        // From 1 to 99999... 00:00:29.5877468 in i7 7700HQ
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
