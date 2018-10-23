// Sergio Ruescas
// Challenge 1.13: Snake

/*
Example of input
4
3
3
3
4
5
3
9
9


Example of output
Caso 1
###
..#
###
Caso 2
####
...#
####
Caso 3
###
..#
###
#..
###
Caso 4
#########
........#
#########
#........
#########
........#
#########
#........
#########
*/

using System;

public class Canicas
{
    public static void Main()
    {
        int casos, altura, anchura;
        casos = Convert.ToInt32( Console.ReadLine() );
        for (int i = 0; i < casos ; i++)
        {
            altura = Convert.ToInt32( Console.ReadLine() );
            anchura = Convert.ToInt32( Console.ReadLine() );
            bool principio = false;
            for (int j = 1 ; j <= altura ; j++)
            {
                if ( j % 2 != 0)
                {
                    for (int z = 0; z < anchura ; z++)
                    Console.Write("#");
                }
                else if (principio == false)
                {
                    
                    for (int z = 1; z <= anchura ; z++)
                    {
                    if ( z == anchura)
                        Console.Write("#");
                    
                    else
                        Console.Write(".");
                    }
                    principio = true;
                    
                }
                else if (principio == true)
                {
                    
                    for (int z = 1; z <= anchura ; z++)
                    {
                    if ( z == 1)
                        Console.Write("#");
                    
                    else
                        Console.Write(".");
                    }
                    principio = false;
                }
                Console.WriteLine();
            }
        }
    }
}


