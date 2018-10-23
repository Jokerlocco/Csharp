//Jaime Francisco Rebollo Domínguez

using System;

public class PiramideDeCanicas
{
    public static void Main()
    {
        int casos;
        
        casos = Convert.ToInt32( Console.ReadLine() );
        
        for(int i = 0; i < casos; i++)
        {
            int altura; 
            long canicas, canicasPiso;
            
            altura = Convert.ToInt32( Console.ReadLine() );
            canicas = 0;
            canicasPiso = 0;
            
            for(int j = 1; j <= altura; j++)
            {
                canicasPiso = canicasPiso + j;
                canicas += canicasPiso;
            }
            
            Console.WriteLine(canicas);
        }
    }
}
