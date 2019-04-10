using System;
using System.IO;
using System.Net;

class DownloadRubyBook
{
    static void Main()
    {
        for (int i = 0; i <= 52; i++)
        {
            WebClient cliente = new WebClient(); 
            Stream conexion = cliente.OpenRead
                ("https://learnrubythehardway.org/book/ex" + i + ".html"); 
            
            StreamReader lector = new StreamReader(conexion); 
            StreamWriter fich = new StreamWriter("Descarga" + i + ".html");
            
            string linea; 
            int contador = 0; 
            
            Console.WriteLine("Rudy " + i + " descargado");
            
            while ((linea=lector.ReadLine()) != null )
            { 
                contador ++; 
                fich.WriteLine(linea); 
            } 
            
            lector.Close();
            conexion.Close();
            fich.Close();
        }
        
        
    }
}
