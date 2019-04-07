// Javier Benajes
// Dates for every 7 days

using System;
using System.IO;

class Fechas7dias
{
    public static void Main()
    {
        StreamWriter fichero = File.CreateText("tasks.txt");

        DateTime fecha = DateTime.Now;

        string[] meses = { "enero", "febrero", "marzo", "abril", 
            "mayo", "junio", "julio",
            "agosto", "septiembre", 
            "octubre", "noviembre", "diciembre" };
        
        int nextYear = DateTime.Now.Year + 1;
        while (fecha.Year < nextYear)
        {
            fichero.WriteLine(fecha.Day.ToString("00") + "-" + 
                meses[fecha.Month - 1].Substring(0, 3) + "-" + 
                fecha.Year.ToString().Substring(2)); 
            fecha = fecha.AddDays(7);
        }
        fichero.Close();
        Console.WriteLine("tasks.txt created")
    }
}
