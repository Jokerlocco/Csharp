/*
Write a program which asks the user for two numbers and an 
operation to perform on them (+,-,*,x,·,/) and displays the
result of that operation, as in this example:

Enter first number: 5
Enter operation: +
Enter second number: 7
5+7=12

(V2: 
- repeated, until the first number is an empty string)
- double data type
- error checking with try-catch
*/

using System;

public class Calculator2
{
    public static void Main()
    {
        double num1, num2;
        char operation;

        Console.Write("Enter first number: ");
        string answer = Console.ReadLine();

        while (answer != "")
        {
            try
            {
                num1 = Convert.ToDouble(answer);

                Console.Write("Enter operation: ");
                operation = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        Console.WriteLine("{0}+{1}={2}",
                            num1, num2, num1 + num2);
                        break;

                    case '-':
                        Console.WriteLine("{0}-{1}={2}",
                            num1, num2, num1 - num2);
                        break;
                    case 'x':
                    case 'X':
                    case '·':
                    case '*':
                        Console.WriteLine("{0}{1}{2}={3}",
                            num1, operation, num2, num1 * num2);
                        break;
                    case '/':
                        Console.WriteLine("{0}/{1}={2}",
                            num1, num2, num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Unknown operation!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }

            Console.Write("Enter first number: ");
            answer = Console.ReadLine();
        }
        Console.WriteLine("Bye!!!");
    }
}
