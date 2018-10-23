//Sergio Ruescas
using System;

public class Pinchazo
{
    public static void Main()
    {
        uint casos;
        casos = Convert.ToUInt32( Console.ReadLine() );
        for (int i = 0; i < casos ; i++)
        {
            ushort inicio, pinchazo;
            inicio = Convert.ToUInt16( Console.ReadLine() );
            pinchazo = Convert.ToUInt16( Console.ReadLine() );
            
            if ((pinchazo - inicio > 180 && pinchazo - inicio <360) || 
                (pinchazo - inicio < 0 && pinchazo - inicio > -180 ))
                    Console.WriteLine("DESCENDENTE");
            
            else if ((pinchazo - inicio > 0 && pinchazo - inicio <180) || 
                (pinchazo - inicio > -360 && pinchazo - inicio < -180 ))
                    Console.WriteLine("ASCENDENTE");
            
            else
                Console.WriteLine("DA IGUAL");
        }
    }
}
