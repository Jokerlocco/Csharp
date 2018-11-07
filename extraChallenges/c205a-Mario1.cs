// María González Martínez
// Reto 2.05 - Los saltos de Mario

/*
Entrada de ejemplo
3
8
1 4 2 2 3 5 3 4
2
9 9
5
1 2 3 4 5

Salida de ejemplo
4 2
0 0
4 0
*/

using System;
public class Mario
{
    public static void Main()
    {
        int casos, muros;
        int saltoArriba, saltoAbajo;
        
        casos = Convert.ToInt32(Console.ReadLine());
                
        for (int i = 1; i <= casos; i++)
        {
            muros = Convert.ToInt32(Console.ReadLine());
            
            saltoArriba = 0;
            saltoAbajo = 0;
            
            string[] datos = Console.ReadLine().Split();
            
            int[] alturas = new int [muros];
        
            for(int j = 0 ; j < muros ; j++)
            {
                alturas[j] = Convert.ToInt32(datos[j]);
            }
            
            for(int j = 0; j < muros-1 ; j++)
            {
                if(alturas[j] > alturas[j+1])
                {
                    saltoAbajo++;
                }
                else if(alturas[j] < alturas[j+1])
                {
                    saltoArriba++;
                }
            }
            
            Console.WriteLine(saltoArriba + " " + saltoAbajo);
            
        }
    }
}
