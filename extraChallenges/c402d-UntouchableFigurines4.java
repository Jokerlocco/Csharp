// Adrián Navarro Gabino

import java.util.*;

public class UntouchableFigurines
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        byte cases = sc.nextByte();
        sc.nextLine();
        
        for(byte actualCase = 0; actualCase < cases; actualCase++)
        {
            String[] auxSize = sc.nextLine().split(" ");
            
            byte width = Byte.parseByte(auxSize[0]);
            byte height = Byte.parseByte(auxSize[1]);

            char[][] floor = new char[height][width];

            for (byte ii = 0; ii < height; ii++)
            {
                String line = sc.nextLine();

                for (byte jj = 0; jj < width; jj++)
                {
                    floor[ii][jj] = line.charAt(jj);
                }
            }

            boolean valid = true;
            byte figure = 0;

            byte i = 0;
            

            while (valid && i < height)
            {
                byte j = 0;
                while (valid && j < width)
                {
                    if (floor[i][j] == 'F')
                    {
                        figure++;
                        if (i == 0 || j == 0 ||
                           i == height - 1 || j == width - 1)
                        {
                            valid = false;
                        }
                        else if (floor[i + 1][j] == 'F' ||
                                floor[i][j + 1] == 'F' ||
                                floor[i + 1][j + 1] == 'F' ||
                                floor[i + 1][j - 1] == 'F')
                        {
                            valid = false;
                        }
                    }
                    j++;
                }
                i++;
            }

            if (valid & figure > 0)
            {
                System.out.println("VALIDA");
            }
            else
            {
                System.out.println("INVALIDA");
            }
        }
    }
}
