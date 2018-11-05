// María González Martínez
// Max of an Array

using System;
public class MaxArray
{
    public static void Main()
    {
        const byte SIZE = 5;
        byte[] data = new byte[SIZE];
        
        for(int i = 0; i < SIZE ; i++)
        {
            Console.Write("Enter data {0}: " , i+1);
            data[i] = Convert.ToByte(Console.ReadLine());
        }
        
        byte max = data[0];
        byte posMax = 0;
        for(byte i = 1; i < SIZE ; i++)
        {
            if(data[i] > max)
            {
                max = data[i];
                posMax = i;
            }
        }
        Console.WriteLine("The max is: " + max +
            ", in position" + (posMax+1));
    }
}
