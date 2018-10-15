// Jorge Calzada Asenjo
// Challenge 1.09 - Team lunch
// Java version

/*
    Calculate the number of tables needed for the team lunch
*/

/*
Sample input
6
4
6
5
3
26073
59794

Sample output
Case #1: 1
Case #2: 2
Case #3: 2
Case #4: 1
Case #5: 13036
Case #6: 29896
*/

import java.util.Scanner;

public class TeamLunch4 {
  public static void main(String[] args) {
    int t, n;

    Scanner reader = new Scanner(System.in);
    t = Integer.parseInt(reader.nextLine());

    for (int cases = 1; cases <= t; cases++) {
      n = Integer.parseInt(reader.nextLine());

      System.out.println("Case #" + cases + ": " + ((n < 5 && n > 0) ? 1 : (n - 1) / 2));
    }
  }
}
