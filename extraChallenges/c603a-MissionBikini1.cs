/*

Se acerca el verano y comienzan los nervios y desesperación por 
mantener una línea adecuada. Para ello muchas personas quieren ponerse 
en forma y se ponen en manos del experto nutricionista Dr Ácula.

El Dr Ácula es un doctor muy solicitado y debe ordenar la lista de 
pacientes en función de quien tiene que atender antes. Este aconsejará 
a los pacientes según mayor urgencia tengan. Para ello los ordenará por 
mayor peso y en caso de empate lo hará según una menor altura.

Entrada

En la primera línea un entero P indicando el número de pacientes.
1 <= C <= 10000
Las siguientes P líneas indicarán de cada paciente el peso w y la altura h.
1 <= h <= 100000
1 <= w <= 100000

Salida

Se nos mostrará los pacientes ordenados de mayor a menor, en base a su 
peso y altura según la urgencia de atención.

Ejemplo de entrada
5
90 150
100 120
100 110
77 170
110 161

Ejemplo de salida
110 161
100 110
100 120
90 150
77 170

*/

// Adrián Navarro Gabino

using System;

class MisionBikini
{
    static void Main()
    {
        int casosDePrueba = Convert.ToInt32(Console.ReadLine());
        
        int[] pesos = new int[casosDePrueba];
        int[] alturas = new int[casosDePrueba];
        
        for(int i = 0; i < casosDePrueba; i++)
        {
            string[] datos = Console.ReadLine().Split();
            
            pesos[i] = Convert.ToInt32(datos[0]);
            alturas[i] = Convert.ToInt32(datos[1]);
        }
        
        for(int i = 0; i < casosDePrueba - 1; i++)
        {
            for(int j = i + 1; j < casosDePrueba; j++)
            {
                if(pesos[i] < pesos[j])
                {
                    int auxPeso = pesos[i];
                    int auxAltura = alturas[i];
                    pesos[i] = pesos[j];
                    alturas[i] = alturas[j];
                    pesos[j] = auxPeso;
                    alturas[j] = auxAltura;
                }
                else if(pesos[i] ==  pesos[j])
                {
                    if(alturas[i] > alturas[j])
                    {
                        int auxPeso = pesos[i];
                        int auxAltura = alturas[i];
                        pesos[i] = pesos[j];
                        alturas[i] = alturas[j];
                        pesos[j] = auxPeso;
                        alturas[j] = auxAltura;
                    }
                }
            }
        }
        
        for(int i = 0; i < casosDePrueba; i++)
        {
            Console.WriteLine(pesos[i] + " " + alturas[i]);
        }
    }
}
