/*

A function “WriteTriangleOfNameR” to display a triangle on screen from a 
certain sentence (extracting the rightmost characters) and with a certain 
maximum height. Each new row should be 1 character longer than the previous 
one, as seen in the following examples:

WriteTriangleOfNameR("Nacho",3);
  o
 ho
cho

WriteTriangleOfNameR("Nacho",20);
    o
   ho
  cho
 acho
Nacho
*/

using System;

public class TriangleOfName
{
    public static void WriteTriangleOfName(string str,int size)
    {
        int spaces;
        int letters;
        
        if (size > str.Length)
            size = str.Length;
        spaces = size - 1;
        letters = 1;
            
        for (int i=0; i < size; i++)
        {
            Console.Write(new string(' ', spaces));
            Console.WriteLine(str.Substring(str.Length-letters));
            
            spaces--;
            letters++;
        }
    }

    public static void Main()
    {
        WriteTriangleOfName("Nacho",3);
        WriteTriangleOfName("Nacho",20);
    }
}
