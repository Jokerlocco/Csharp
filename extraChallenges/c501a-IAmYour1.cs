// Reto 5.01
// Daniel Contreras

/*
Entrada de ejemplo

4
C-3PO
creador
Luke
padre
Princesa
Principe
Luke
Padre

Salida de ejemplo

C-3PO, yo soy tu creador
TOP SECRET
Princesa, yo soy tu Principe
Luke, yo soy tu Padre
*/

using System;

class YoSoyTuPadreReto501
{
    static void Main()
    {
        string name, relative;
        int cases = Convert.ToInt32(Console.ReadLine());

        while (cases > 0)
        {
            name = Console.ReadLine();
            relative = Console.ReadLine();
            
            if (name == "Luke" && relative == "padre")
            {
                Console.WriteLine("TOP SECRET");
            }
            else
            {
                Console.WriteLine(name + ", yo soy tu " + relative);
            }
            cases--;
        }               
    }
}
