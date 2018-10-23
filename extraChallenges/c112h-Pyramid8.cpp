// Jorge Calzada Asenjo
// Challenge 1.12: Pyramid of marbles
// Java version

/*
    To calculate how many marbles form a pyramid with triangular base knowing
    the height of the pyramid.
*/

/*
    Example of input
    4
    1
    2
    3
    4


    Example of output
    1
    4
    10
    20
*/

import java.util.Scanner;

public class Pyramid2 {
    public static void main(String[] args) {
        int cases;
        long height, totalPyramid;

        Scanner reader = new Scanner(System.in);

        cases = Integer.parseInt(reader.nextLine());

        for (int i = 0; i < cases; i++) {
            height = Integer.parseInt(reader.nextLine());

            totalPyramid = (height * (height + 1) * (height + 2)) / 6;

            System.out.println(totalPyramid);
        }
    }
}
