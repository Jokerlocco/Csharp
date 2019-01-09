//Sergio Ruescas
using System;

class orden
{
    private string nombre;
    private string direccion;
    
    public void SetNombre(string n)
    {
        nombre = n;
    }
    public void SetDireccion(string d)
    {
        direccion = d;
    }
    
    public string GetNombre()
    {
        return nombre;
    }
    
    public string GetDireccion()
    {
        return direccion;
    }
    
}


class Conversacional
{
    
    public static orden o = new orden();
    public static int[,] mapa = {
        {1,1,1,1,1,2,1},
        {1,0,1,0,2,0,1},
        {1,2,1,2,1,1,1},
        {1,0,2,0,1,1,1},
        {1,1,1,1,1,1,1},
    };
    
    public static void EjecutarOrden(ref int x, ref int y, ref int energia,
        ref bool terminado)
    {
        Console.WriteLine();
        
        if (o.GetNombre() == "mirar")
        {
            string mostrar = "";
            if ( o.GetDireccion() == "norte" )
            {
                
                if ( mapa[y-1,x] == 1 )
                {
                    mostrar = "pared";
                }
                else if ( mapa[y-1,x] == 2)
                {
                    mostrar = "puerta";
                }
            }
            
            else if ( o.GetDireccion() == "sur" )
            {
                
                if ( mapa[y+1,x] == 1 )
                {
                    mostrar = "pared";
                }
                else if ( mapa[y+1,x] == 2)
                {
                    mostrar = "puerta";
                }
            }
            
            else if ( o.GetDireccion() == "este" )
            {
                
                if ( mapa[y,x+1] == 1 )
                {
                    mostrar = "pared";
                }
                else if ( mapa[y,x+1] == 2)
                {
                    mostrar = "puerta";
                }
            }
            
            else if ( o.GetDireccion() == "oeste" )
            {
                
                if ( mapa[y,x-1] == 1 )
                {
                    mostrar = "pared";
                }
                else if ( mapa[y,x-1] == 2)
                {
                    mostrar = "puerta";
                }
            }
            
            if ( mostrar == "puerta" )
            {
                Console.WriteLine("\\            /");
                Console.WriteLine(" \\----------/");
                Console.WriteLine("  |         |");
                Console.WriteLine("  |   ----  |");
                Console.WriteLine("  |   |  |  |");
                Console.WriteLine("  |   |  |  |");
                Console.WriteLine(" /----------\\");
                Console.WriteLine("/            \\");
            }
            
            else if ( mostrar == "pared")
            {
                Console.WriteLine("\\           /");
                Console.WriteLine(" \\---------/");
                Console.WriteLine(" |         |");
                Console.WriteLine(" |         |");
                Console.WriteLine(" |         |");
                Console.WriteLine(" |         |");
                Console.WriteLine(" /---------\\");
                Console.WriteLine("/           \\");
            }
            else 
                Console.WriteLine("Direccion desconocida.");
        }
        
        else if (o.GetNombre() == "avanzar")
        {
            if ( o.GetDireccion() == "norte" )
            {
                if ( x == 5 && y == 1 )
                {
                    Console.WriteLine("Has escapado! Bien jugado.");
                    terminado = true;
                }
                else
                {
                    if ( mapa[y-1,x] == 1 )
                    {
                        energia -= 2;
                        Console.Write("He chocado con una pared.");
                        Console.WriteLine(
                            "Pierdo un punto de energia. Energia actual: {0}"
                                , energia);
                    }
                    else if ( mapa[y-1,x] == 2)
                    {
                        energia--;
                        Console.WriteLine(
                            "Entro a otra habitacion. Energia actual: {0}",
                                energia);
                        y -= 2;
                    }
                }
            }
            
            else if ( o.GetDireccion() == "sur" )
            {
                if ( mapa[y+1,x] == 1 )
                {
                    energia -= 2;
                    Console.Write("He chocado con una pared.");
                    Console.WriteLine(
                        "Pierdo un punto de energia. Energia actual: {0}"
                            , energia);
                }
                else if ( mapa[y+1,x] == 2)
                {
                    energia--;
                    Console.WriteLine(
                        "Entro a otra habitacion. Energia actual: {0}",
                            energia);
                    y += 2;
                }
            }
            
            else if ( o.GetDireccion() == "oeste" )
            {
                if ( mapa[y,x-1] == 1 )
                {
                    energia -= 2;
                    Console.Write("He chocado con una pared.");
                    Console.WriteLine(
                        "Pierdo un punto de energia. Energia actual: {0}"
                            , energia);
                }
                else if ( mapa[y,x-1] == 2)
                {
                    energia--;
                    Console.WriteLine(
                        "Entro a otra habitacion. Energia actual: {0}",
                            energia);
                    x -= 2;
                }
            }
            
            else if ( o.GetDireccion() == "este" )
            {
                if ( mapa[y,x+1] == 1 )
                {
                    energia -= 2;
                    Console.Write("He chocado con una pared.");
                    Console.WriteLine(
                        "Pierdo un punto de energia. Energia actual: {0}"
                            , energia);
                }
                else if ( mapa[y,x+1] == 2)
                {
                    energia--;
                    Console.WriteLine(
                        "Entro a otra habitacion. Energia actual: {0}",
                            energia);
                    x += 2;
                }
            }
            else
                Console.WriteLine("Direccion desconocida.");
        }
        else if (o.GetNombre() != "x" || o.GetDireccion() != "x")
            Console.WriteLine("Orden desconocida.");
        Console.WriteLine();
    }
    
    static void Main()
    {
        int x = 1, y = 3;
        int energia = 15;
        bool terminado = false;
        string entrada;
        string[] entradaDividida = new string[2];
        Console.WriteLine(
            "Bienvenido a esta pequeña aventura conversacional.");
        Console.Write("Debes escribir la orden \"mirar\" o \"avanzar\" ");
        Console.WriteLine("seguido de un espacio y la direccion.");
        Console.WriteLine("Direcciones posibles: norte, sur, este, oeste.");
        Console.WriteLine("Al inicio de la partida tienes 15 puntos de vida.");
        Console.WriteLine(
            "Por cada \"avanzar\" pierdes 1 punto y por cada choque 1 mas.");
        Console.WriteLine("Puedes abandonar escribiendo X X");
        Console.WriteLine("Preparado? ADELANTE!");
        
        do 
        {
            entrada = Console.ReadLine().ToLower();
            if (entrada == "")
                continue;
            entradaDividida = entrada.Split();
            
            o.SetNombre( entradaDividida[0] );
            o.SetDireccion( entradaDividida[1] );
            EjecutarOrden(ref x, ref y, ref energia, ref terminado);
            
        } while (energia > 0 && entrada != "x x" && !terminado);
        
        if (energia == 0)
            Console.WriteLine("Has muerto.");
    }
}
