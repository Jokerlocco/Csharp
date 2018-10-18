// María González Martínez
// "char" - if & switch

using System;

class CharsIfSwitch
{
    static void Main()
    {
        Console.Write("Enter a char: ");
        char c = Convert.ToChar(Console.ReadLine());
        
        if(c >= '0' && c <= '9')
            Console.WriteLine("It's a digit");
        else if (c == '+' || c == '-' || c == '*' ||
                    c == '/' || c == '%')
                Console.WriteLine("It's an operator");
        else if (c == '.' || c == ',' || c == ';' ||
                    c == ':')
                Console.WriteLine("It's a punctuation symbol");
        else
            Console.WriteLine("Wrong character");
        
        switch (c)
        {
            case'0':
            case'1':
            case'2':
            case'3':
            case'4':
            case'5':
            case'6':
            case'7':
            case'8':
            case'9': Console.WriteLine("It's a digit"); break;
            case'+':
            case'-':
            case'*':
            case'/':
            case'%': Console.WriteLine("It's an operator"); break;
            case'.':
            case',':
            case':':
            case';': Console.WriteLine("It's a punctuation symbol"); break;
            default: Console.WriteLine("Wrong character"); break;
        }    
    }
}
