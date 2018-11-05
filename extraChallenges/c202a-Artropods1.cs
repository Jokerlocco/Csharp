//Kevin Marín Romero
//Artropodos

/*
Entrada de ejemplo
2
1 1 1 1 15
2 3 1 4 52

Salida de ejemplo
54
462
*/

using System;

public class Artropodos
{
    public static void Main()
    {
        int cases;
        string[] inputs = new string[5];
        int[] numbers = new int[5];
        
        cases = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < cases; i++)
        {
            inputs = Console.ReadLine(). Split();
            
            for (int j = 0; j < inputs.Length; j++)
            {
                numbers[j] = Convert.ToInt32(inputs[j]);
            }
            
            Console.WriteLine(numbers[0] * 6 + numbers[1] * 8 + 
                numbers[2] * 10 + (numbers[3] * 2) * numbers[4]);
        }
        
    }
}
