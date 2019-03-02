// Jorge Calzada Calzada

using System;
using System.Collections.Generic;

class Calculadora
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();

        string text;
        int num1, num2;

        do
        {
            text = Console.ReadLine();
            string[] parts = text.Split();
            foreach(string part in parts)
            {
        

            switch (part)
            {
                case "+":
                    num1 = pila.Pop();
                    num2 = pila.Pop();
                    pila.Push(num1 + num2);
                    break;
                case "-":
                    num1 = pila.Pop();
                    num2 = pila.Pop();
                    pila.Push(num1 - num2);
                    break;
                case "*":
                    num1 = pila.Pop();
                    num2 = pila.Pop();
                    pila.Push(num1 * num2);
                    break;
                case "/":
                    num1 = pila.Pop();
                    num2 = pila.Pop();
                    pila.Push(num1 / num2);
                    break;
                case ".":
                    Console.WriteLine(pila.Pop());
                    break;
                default:
                    try
                    {
                        pila.Push(Convert.ToInt32(part));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("El valor introducido no es correcto");
                    }
                    break;
                }
            }

        } while (text != "");

        
    }
}
