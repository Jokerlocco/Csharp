//Gonzalo Arques
using System;
public class NombrePrograma
{
    public static void Main()
    {

        Console.Write("Inserta un símbolo: ");
        string dato = (Console.ReadLine());

        switch (dato)
        {
            case "<":
            case ">":
            case "<=":
            case ">=":
            case "==":
            case "!=": 
                Console.WriteLine("Es un comparador"); 
                break;

            case "+":
            case "-":
            case "*":
            case "/":
            case "%": 
                Console.WriteLine("Es un operador aritmético"); 
                break;

            case "\"":
            case "'":
            case "(":
            case ")": 
                Console.WriteLine("Es un delimitador de texto"); 
                break;

            default: 
                Console.WriteLine("Es otra cosa"); 
                break;
        }

        if ((dato == "<") || (dato == ">") || (dato == "<=")
                || (dato == ">=") ||  (dato == "==") || (dato == "!="))
            Console.WriteLine("Es un comparador");
        else if ((dato == "+") || (dato == "-") || (dato == "*")
                || (dato == "/") ||  (dato == "%"))
            Console.WriteLine("Es un operador aritmético");
        else if ((dato == "\"") || (dato == "'"))
            Console.WriteLine("Es un delimitador de texto");
        else
            Console.WriteLine("Es otro tipo de dato");
    }
}
