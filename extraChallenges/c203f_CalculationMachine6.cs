//Kevin Marín Romero
//Máquina de Cálculo

/*
Example of input
5
5 + -13
10 / 2
7 * 3
3 / 0
5 - 13

Example of output
-8
5
21
ERROR
-8
*/

using System;

public class MaquinaCalculo
{
    public static void Main()
    {
        short cases;
        string[] data = new string[3];
        int num1, num2;

        cases = Convert.ToInt16(Console.ReadLine());

        for (short i = 0; i < cases; i++)
        {
            data = Console.ReadLine().Split();
            num1 = Convert.ToInt32(data[0]);
            num2 = Convert.ToInt32(data[2]);

            Console.WriteLine(((data[1] == "/") && (data[2] == "0"))? 
                "ERROR" : Convert.ToString(
                    ((data[1] == "+")? 
                    (num1 + num2):
                    (data[1] == "-") ?
                    (num1 - num2):
                    (data[1] == "*") ?
                    (num1 * num2):
                    (num1 /  num2))));
        }
    }
}
