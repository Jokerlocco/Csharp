// Jorge Calzada Asenjo
// Challenge 1.10: Gregory XIII
// Java version

/*
    Calculate how many days you have in February in a given year
*/

/*
Example of input
4
1584
1600
1699
1700


Example of output
29
29
28
28
*/

import java.util.Scanner;

public class Gregory2 {
    public static void main(String[] args) {
        int cases, year;

        Scanner reader = new Scanner(System.in);

        cases = Integer.parseInt(reader.nextLine());

        for (int i = 0; i < cases; i++) {
            year = Integer.parseInt(reader.nextLine());

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) {
                System.out.println(29);
            } else {
                System.out.println(28);
            }
        }
    }
}
