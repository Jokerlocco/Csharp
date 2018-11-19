/*
Crea un programa para administrar una colección de videos (título, duración en 
segundos, tamaño en kb). Debe permitir al usuario añadir videos (opción 1), 
mostrar todos los videos (opción 2) y buscar (búsqueda parcial, en el título, 
opción 3), ordenar los datos por tamaño (ascendente, opción 4).
*/

// Javier Benajes
using System;

public class ColeccionVideosOrdenacion
{
    struct video
    {
        public string titulo;
        public ushort duracion;
        public uint tamanyo;
    }

    public static void Main()
    {
        const int capacidad = 1000;
        video[] videos = new video[capacidad];

        int opcion = 0;
        int cantidad = 0;

        do
        {
            Console.WriteLine("COLECCIÓN DE VÍDEOS");
            Console.WriteLine();
            Console.WriteLine("1- Añadir");
            Console.WriteLine("2- Mostrar");
            Console.WriteLine("3- Buscar por título");
            Console.WriteLine("4- Ordenar por tamaño");
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1: // Añadir
                    if (cantidad < capacidad)
                    {
                        Console.Write("Título: ");
                        videos[cantidad].titulo = Console.ReadLine();
                        Console.Write("Duración: ");
                        videos[cantidad].duracion = Convert.ToUInt16(
                            Console.ReadLine());
                        Console.Write("Tamaño: ");
                        videos[cantidad].tamanyo = Convert.ToUInt32(
                            Console.ReadLine());
                        Console.WriteLine();
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("La colección de vídeos está llena.");
                        Console.WriteLine();
                    }
                    break;
                case 2: // Mostrar
                    if (cantidad == 0)
                    {
                        Console.WriteLine("La colección de vídeos está vacía.");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("VÍDEO Nº{0}", i + 1);
                            Console.WriteLine("Título: {0}", videos[i].titulo);
                            Console.WriteLine("Duración: {0}", videos[i].duracion);
                            Console.WriteLine("Tamaño: {0}", videos[i].tamanyo);
                            Console.WriteLine();
                        }
                    }
                    break;
                case 3: // Buscar por título
                    if (cantidad == 0)
                    {
                        Console.WriteLine("La colección de vídeos está vacía.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(
                            "Introduce el título del vídeo que quieres buscar: ");
                        string buscar = Console.ReadLine();
                        Console.WriteLine();

                        int cantidadEncontrados = 0;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (videos[i].titulo.ToUpper().Contains(
                                buscar.ToUpper()) )
                            {
                                Console.WriteLine("VÍDEO Nº{0}", i + 1);
                                Console.WriteLine("Título: {0}", videos[i].titulo);
                                Console.WriteLine("Duración: {0}", videos[i].duracion);
                                Console.WriteLine("Tamaño: {0}", videos[i].tamanyo);
                                Console.WriteLine();
                                cantidadEncontrados++;
                            }
                        }

                        if (cantidadEncontrados == 0)
                            Console.WriteLine(
                                "No se ha encontrado ningún vídeo con \"{0}\".", 
                                buscar);
                        else if (cantidadEncontrados == 1)
                            Console.WriteLine(
                                "Se ha encontrado {0} vídeo con \"{1}\".", 
                                cantidadEncontrados, buscar);
                        else
                            Console.WriteLine(
                                "Se ha encontrado {0} vídeos con \"{1}\".", 
                                cantidadEncontrados, buscar);

                        Console.WriteLine();
                    }
                    break;
                case 4: // Ordenar por tamaño
                    if (cantidad == 0)
                    {
                        Console.WriteLine("La colección de vídeos está vacía.");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < cantidad - 1; i++)
                        {
                            for (int j = i + 1; j < cantidad; j++)
                            {
                                if (videos[i].tamanyo > videos[j].tamanyo)
                                {
                                    video aux = videos[i];
                                    videos[i] = videos[j];
                                    videos[j] = aux;
                                }
                            }
                        }
                        Console.WriteLine(
                            "La colección de vídeos ha sido ordenada por tamaño.");
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Hasta luego!");
                    break;
            }
        } while (opcion != 0);
    }
}
