// Manuel lago

using System;
using System.IO;

class HexDump
{
    public static void Main()
    {
        // TO DO: Error checking, using "args"
        
        Console.WriteLine("Nombre:");
        string nombre = Console.ReadLine();
        
        FileStream leerB = new FileStream(nombre,FileMode.Open);
        int tamanyoBloque = 16;
        
        byte[] bloque = new byte[tamanyoBloque];
        string[] bloqueHex = new string[leerB.Length];
        int cantidadLeer = leerB.Read(bloque,0,tamanyoBloque);
        
        while(cantidadLeer > 0)
        {
            string hex = "";
            string cha = "";
            
            for(int i = 0 ; i < cantidadLeer; i++)
            {
                hex += bloque[i].ToString("X2") + " ";
                
                if(bloque[i] > 32)
                {
                    
                    cha += (char) bloque[i] + " ";
                }
                else
                {
                    cha += ". ";
                }
            }
            
            Console.WriteLine(hex + cha);
            bloque = new byte[tamanyoBloque];
            bloqueHex = new string[leerB.Length];
            cantidadLeer = leerB.Read(bloque,0,cantidadLeer);
        }
        
        leerB.Close();
        
    }
}
