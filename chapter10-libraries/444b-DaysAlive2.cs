using System;

class DaysAlive2
{
    public static void Main()
    {
        Console.Write("Fecha de nacimiento (DD/MM/AAAA): ");
        string fecha = Console.ReadLine();
        string[] cortar = fecha.Split('/');
        
        DateTime hoy = DateTime.Now;
        DateTime nacimiento = new DateTime(Convert.ToInt32(cortar[2]),
            Convert.ToInt32(cortar[1]),Convert.ToInt32(cortar[0]));
        
        TimeSpan dif = hoy.Subtract(nacimiento);
        
        Console.WriteLine("Has vivido " + dif.Days + " dias");
    }
}
