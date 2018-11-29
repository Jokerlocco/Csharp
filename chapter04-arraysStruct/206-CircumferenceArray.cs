using System;

class Circumference 
{
  static void Main () 
  {
    int sizeX = 70;
    int sizeY = 20;
    int xCenter = sizeX / 2;
    int yCenter = sizeY / 2;
    int radius = 8;
    byte[,] screen = new byte[sizeX, sizeY];

    // Traverse all the points from 0 to 360º
    for (int i = 0; i < 360; i+=5)
    {
      // Convert the angle from degrees to radians
      double radians = (i * Math.PI / 180.0);
      
      // Find the coordinates of each point
      double x = xCenter + radius * Math.Cos(radians);
      double y = yCenter + radius * Math.Sin(radians);

      // "Draw" the point in the array
      screen[ (int) x, (int) y ] = 1;
    }

    // Finally, dump the array to the screen
    for(int row=0; row < sizeY; row++)
    {
      for(int column=0; column < sizeX; column++)
      {
        if (screen[ column, row ] == 1)
          Console.Write( "*" );
        else
          Console.Write( " " );
      }
      Console.WriteLine();
    }
  }
}
