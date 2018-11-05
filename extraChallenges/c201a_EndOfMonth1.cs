// Pablo Sánchez Alonso
// Reto 2.01: Fin de mes

/*
Entrada de ejemplo
8
100 -10
-10 -100
-10 100
100 -1000
2500 -2490
9500 -9500
-100 99
50 -50

Salida de ejemplo
SI
NO
SI
NO
SI
SI
NO
SI
*/

using System;
class FinDeMes
{
    static void Main()
    {
        int casos;
        short dineroInicial, cambio, dineroFinal;
        
        casos = Convert.ToInt32(Console.ReadLine());
                
        for ( int i = 1; i <= casos; i++ )
        {
            string[] dinero = Console.ReadLine().Split();
    
            dineroInicial = Convert.ToInt16(dinero[0]); 
            cambio = Convert.ToInt16(dinero[1]);
            
            dineroFinal = (short) (dineroInicial + cambio);
        
            string respuesta = dineroFinal >= 0 ? "SI" : "NO";
            
            Console.WriteLine(respuesta);
        }
    }
}
