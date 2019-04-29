/*
The Mayan civilisation used three different calendars. In their long count 
calendar there were 20 days (called kins) in a uinal, 18 uinals in a tun, 20 
tuns in a katun and 20 katuns in a baktun. In our calendar, we specify a date 
by giving the day, then month, and finally the year. The Maya specified dates 
in reverse, giving the baktun (1-20), then katun (1-20), then tun (1-20), then 
uinal (1-18) and finally the kin (1-20).

The Mayan date 13 20 7 16 3 corresponds to the date 1 January 2000 (which was a 
Saturday).

Write a program which, given a Mayan date (between 13 20 7 16 3 and 14 1 15 12 
3 inclusive), outputs the corresponding date in our calendar. You should output 
the month as a number.

Sample run

13 20 9 2 9
22 3 2001
*/

// Adrián Navarro Gabino

using System;
using System.Linq;

class MayanCalendar
{
    static void Main()
    {
        int firstDay = 18*20*20*20*13 + 18*20*20*20 + 18*20*7 + 20*16 + 3;
        DateTime firstDate = new DateTime(2000, 1, 1);
        
        string[] inputDate = Console.ReadLine().Split();
        
        int[] currentDayAux = new int[inputDate.Length];
        for(int i = 0; i < inputDate.Length; i++)
        {
            currentDayAux[i] = Convert.ToInt32(inputDate[i]);
        }
        
        int currentDay = 18*20*20*20*currentDayAux[0] +
            18*20*20*currentDayAux[1] + 18*20*currentDayAux[2] +
            20*currentDayAux[3] + currentDayAux[4];
            
        DateTime currentDate = firstDate.AddDays(currentDay - firstDay);
        
        Console.WriteLine(
            currentDate.Day + " " + currentDate.Month + " " + currentDate.Year);
    }
}
