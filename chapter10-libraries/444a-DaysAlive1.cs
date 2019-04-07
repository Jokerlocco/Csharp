using System;
using System.IO;

class DaysAlive1
{
    public static void Main()
    {
        DateTime hoy = DateTime.Now;
        Console.Write("Dia que naciste: ");
        int dd = Convert.ToInt16(Console.ReadLine());
        Console.Write("Mes que naciste: ");
        int mm = Convert.ToInt16(Console.ReadLine());
        Console.Write("Año que naciste: ");
        int yyyy = Convert.ToInt32(Console.ReadLine());
        DateTime nacimiento = new DateTime(yyyy,mm,dd);
        TimeSpan dif = hoy.Subtract(nacimiento);
        
        Console.WriteLine("Dias vividos: " + dif.Days);
    }
}
