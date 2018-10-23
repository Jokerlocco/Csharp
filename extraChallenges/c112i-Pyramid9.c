// Jorge Calzada Asenjo
// Challenge 1.12: Pyramid of marbles
// C version

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

#include <stdio.h>

int main()
{
    int cases, i;
    unsigned long long height, totalPyramid;

    scanf("%d", &cases);

    for (i = 0; i < cases; i++)
    {
        scanf("%lld", &height);

        totalPyramid = (height * (height + 1) * (height + 2)) / 6;

        printf("%llu\n", totalPyramid);
    }

    return 0;
}
