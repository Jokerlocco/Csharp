// Sergio Ruescas

using System;

public class MilesPerSecond
{
  public static void Main()
  {
    int miles, seconds;  // input data
    int metersPerSecond, kilometersPerHour, milesPerHour;  // results
    
    Console.Write("Enter miles: ");
    miles = Convert.ToInt32( Console.ReadLine() );
    Console.Write("Enter seconds: ");
    seconds = Convert.ToInt32( Console.ReadLine() );
    
	metersPerSecond = miles*1609 / seconds;
	kilometersPerHour = metersPerSecond * 3600 / 1000;
	milesPerHour = miles * 3600 / seconds;
	
	Console.WriteLine("It is {0} meter per second", metersPerSecond);
	Console.WriteLine("It is {0} kilometers per hour", kilometersPerHour);
	Console.WriteLine("It is {0} miles per hours", milesPerHour);
    
  }
}
