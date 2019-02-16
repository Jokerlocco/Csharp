/*
Ejemplo de entrada
5
UtQ.iNlLgT;{f,.GR!
yr)Z,pHQ+No,ZfP_z12D2l1* MSTfk
.p7hV/Es^aahW%B.1JJouO;
c7V!*$1lW
a^pBAAxCohQlBv7qDpVeOB%Min

Ejemplo de salida
ERROR
OK
OK
ERROR
OK
*/
using System;

class ValidPassword
{
    public static bool IsValidPassword(string s)
    {
        if (s.Length < 12)
            return false;

        bool containsUC = false,
            containsLC = false,
            containsDig = false,
            containsSym = false;

        foreach (char c in s)
        {
            if ((c >= 'A') && (c <= 'Z'))
                containsUC = true;
            if ((c >= 'a') && (c <= 'z'))
                containsLC = true;
            if ((c >= '0') && (c <= '9'))
                containsDig = true;
            if ("+_)(*&^%$#@!./,;{}".Contains(""+c))
                containsSym = true;
        }

        return containsUC && containsLC 
            && containsDig && containsSym;
    }

    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (IsValidPassword(Console.ReadLine() ))
                Console.WriteLine("OK");
            else
                Console.WriteLine("ERROR");
        }
    }
}
