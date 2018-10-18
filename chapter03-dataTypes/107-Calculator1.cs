/*
Write a program which asks the user for two numbers and an 
operation to perform on them (+,-,*,x,·,/) and displays the
result of that operation, as in this example:

Enter first number: 5
Enter operation: +
Enter second number: 7
5+7=12
*/

using System;

public class Calculator1
{
    public static void Main()
    {
        int num1,num2;
        char operation;
        
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter operation: ");
        operation = Convert.ToChar(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
                
        switch (operation)
        {
            case '+':
                Console.WriteLine("{0}+{1}={2}",
                    num1, num2, num1+num2);
                break;
                
            case '-':
                Console.WriteLine("{0}-{1}={2}",
                    num1, num2, num1-num2);
                break;
            case 'x':
            case 'X':
            case '·':
            case '*':
                Console.WriteLine("{0}{1}{2}={3}",
                    num1, operation, num2, num1*num2);
                break;
            case '/':
                Console.WriteLine("{0}/{1}={2}",
                    num1, num2, num1/num2);
                break;
            default:
                Console.WriteLine("Unknown operation!");
                break;
        }

    }
}
