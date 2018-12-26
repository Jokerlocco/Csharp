// Javier Benajes

using System;

class Calculator
{
    static void Main(string[] args)
    {
        if (args.Length == 3)
        {
            int firstNumber = Convert.ToInt32(args[0]);
            int secondNumber = Convert.ToInt32(args[2]);
            string operation = args[1];

            switch (operation)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                case "x":
                case "X":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
                default:
                    Console.WriteLine("Operator not valid.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Not enough parameters.");
        }
    }
}
