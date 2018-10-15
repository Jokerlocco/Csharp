// Jorge Calzada Asenjo
// Challenge 1.10: Gregory XIII
// C version

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

#import <stdio.h>

int main()
{
    int cases, year;

    scanf("%d", &cases);

    for (int i = 0; i < cases; i++)
    {
        scanf("%d", &year);

        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            printf("29\n");
        } else {
            printf("28\n");
        }
    }

    return 0;
}
