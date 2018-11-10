// Adrián Navarro Gabino

using System;

public class Estadistica
{
    public static void Main()
    {
        int opcion;
        int numeroDeDatos = 0;
        double[] datos = new double[1000];
        
        double buscar;
        
        bool estaEn = false;
        
        double suma;
        double media;
        double maximo;
        double minimo;
        
        do
        {
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1) Añadir dato");
            Console.WriteLine("2) Ver datos introducidos");
            Console.WriteLine("3) Buscar un dato");
            Console.WriteLine("4) Ver resumen de estadísticas");
            Console.WriteLine("0) Salir");
            
            opcion = Convert.ToInt32(Console.ReadLine());
            
            switch(opcion)
            {
                case 1:
                    try
                    {
                        if (numeroDeDatos < 999)
                        {
                            Console.WriteLine("Introduce el dato {0}",
                                numeroDeDatos + 1);
                            datos[numeroDeDatos] =
                                Convert.ToDouble(Console.ReadLine());
                            numeroDeDatos++;
                        }
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Dato incorrecto");
                    }
                    break;
                case 2:
                    Console.WriteLine("Datos introducidos:");
                    for(int i = 0; i < numeroDeDatos; i++)
                        Console.Write(datos[i] + " ");
                    break;
                case 3:
                    Console.WriteLine("¿Qué dato quieres buscar?");
                    buscar = Convert.ToDouble(Console.ReadLine());
                    
                    for(int i = 0; i < numeroDeDatos; i++)
                    {
                        if(buscar == datos[i])
                            estaEn = true;
                    }
                    if(estaEn)
                        Console.WriteLine("{0} está entre los datos", buscar);
                    else
                        Console.WriteLine("{0} no está entre los datos",
                            buscar);
                    break;
                case 4:
                    Console.WriteLine("Cantidad de datos: " + numeroDeDatos);
                    
                    suma = 0;
                    for(int i = 0; i < numeroDeDatos; i++)
                        suma += datos[i];
                    Console.WriteLine("Suma: " + suma);
                    
                    media = suma / numeroDeDatos;
                    Console.WriteLine("Media: " + media);
                    
                    maximo = minimo = datos[0];
                    for(int i = 0; i < numeroDeDatos; i++)
                    {
                        if(datos[i] > maximo)
                            maximo = datos[i];
                        if(datos[i] < minimo)
                            minimo = datos[i];
                    }
                    Console.WriteLine("Máximo: " + maximo);
                    Console.WriteLine("Mínimo: " + minimo);
                    
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        } while(opcion != 0);
    }
}
