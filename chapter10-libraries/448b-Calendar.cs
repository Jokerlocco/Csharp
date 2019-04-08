// José Vicente Antón Castelló
// Calendar of a month

using System;

class Calendario
{
    static void Main(string[] args)
    {
        string[] meses = {
            "Enero","Febrero","Marzo",
            "Abril","Mayo","Junio",
            "Julio","Agosto","Septiembre"
            ,"Octubre","Noviembre","Diciembre"
        };

        Console.Write("Año: ");
        int anyo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mes: ");
        int mes = Convert.ToInt32(Console.ReadLine());

        DateTime primerDia = new DateTime(anyo, mes, 1);
        int diaSemana = (int) primerDia.DayOfWeek - 1;
        DateTime diaActual = new DateTime(anyo, mes, 1);
        Console.WriteLine(meses[primerDia.Month - 1]
            + " " + primerDia.Year);

        Console.WriteLine("lu ma mi ju vi sa do");

        Console.Write(new string(' ', diaSemana*3));

        while (diaActual.Month == primerDia.Month)
        {
            string actual = diaActual.Day.ToString();

            Console.Write((actual.Length == 1 
                ? " " : "") 
                + actual + " ");

            if(((int) diaActual.DayOfWeek) % 7 == 0)
                Console.WriteLine();

            diaActual = diaActual.AddDays(1);
        }
        Console.WriteLine();
    }
}

