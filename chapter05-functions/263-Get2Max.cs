/* 
 * Daniel Contreras, una corrección por Nacho
 * 263 - Repaso Navidad 08 - Función Obtener2Max
 * 
 * Crea una función Obtener2Max que obtenga el valor máximo y 
 * el segundo valor más alto en una matriz de floats
 */

using System;

class RepasoNavidad263
{
    static void Obtener2Max(float[] data, out float max, out float segundo)
    {
        /* Nota: Este planteamiento falla si el máximo está en la 
         * primera posición, como en la "prueba 2" */
        max = data[0];
        segundo = data[0];
        /* Como alternativa más fiable, podemos dar una primera pasada
         * para darles a ambos el valor mínimo */
        foreach(float d in data)
        {
            if (d < max) max = d;
            if (d < segundo) segundo = d;
        }

        /* El resto del algoritmo es "más natural" */
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > max)  // Si hay un nuevo máximo
            {
                // Quizá el máximo anterior pase a ser el segundo
                if (segundo < max)
                    segundo = max;
                // Y, en cualquier caso, lo memorizamos
                max = data[i];
            }
            // Si no, si hay un nuevo segundo, lo memorizamos
            else if ((data[i] > segundo) && (data[i] < max))
            {
                segundo = data[i];
            }
        }
        
        
    }
    static void Main()
    {
        
        float[] data;
        float max, segundo;
        
        Console.WriteLine("Primera prueba:");
        data = new float[]{2, 7.5f, 6, -1, 20, 5};
        Obtener2Max(data, out max, out segundo);
        Console.WriteLine("El máximo es " + max + " el segundo " + segundo);
        
        Console.WriteLine("Segunda prueba:");
        data = new float[]{20, 7.5f, 6, -1, 20, 5};
        Obtener2Max(data, out max, out segundo);
        Console.WriteLine("El máximo es " + max + " el segundo " + segundo);
        
        Console.WriteLine("Tercera prueba:");
        data = new float[]{5, 5, 5};
        Obtener2Max(data, out max, out segundo);
        Console.WriteLine("El máximo es " + max + " el segundo " + segundo);
        
    }
}
