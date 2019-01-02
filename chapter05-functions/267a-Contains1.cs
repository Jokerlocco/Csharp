/* - Daniel Contreras

267 - Repaso Navidad 12 - Funciones Contains y ContainsR

Crea dos funciones que indiquen si una cadena contiene un cierto carácter. La 
primera función debe hacerlo de manera iterativa (NO recursiva, sino usando 
"for" o "while"), y debe llamarse "Contains". La segunda función debe hacerlo 
de manera recursiva (sin usar "for" ni "while"), y debe llamarse "ContainsR". 
Un ejemplo de uso podría ser:

if ( Contains( "Hola" ,'a' ) ) Console.Write("Hay una A");

Write ( ContainsR( "Hola", 'b') );
*/

using System;

class RepasoNavidad267
{
    //iterative function
    static bool Contains(string text, char c)
    {
        bool found = false;
        
        for(int i = 0; i < text.Length; i++)
        {
            if (text[i] == c)
            {
                found = true;
            }
        }
        return found;
    }
    
    //recursive function
    static bool ContainsR(string text, char c)
    {   
        if (text.Length == 0)
        {
            return false;
        }
        else if (text[0] == c)
        {
            return true;
        }
        else
        {
            return ContainsR(text.Substring(1), c);
        }   
    }   
    
    static void Main()
    {
        //iterative example
        if (Contains("Hola", 'a'))
        {
            Console.WriteLine("Hay una \"a\"");
        }
        else
        {
            Console.WriteLine("No hay una \"a\"");
        }
        
        //recursive example
        Console.Write(ContainsR("Hola", 'a'));
    }
}
