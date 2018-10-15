// Jorge Calzada Asenjo
// Challenge 1.09 - Team lunch
// C version

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

#include <stdio.h>

int main()
{
    int t, n;

    scanf("%d", &t);

    for (int cases = 1; cases <= t; cases++)
    {
        scanf("%d", &n);

        printf("Case %d: %d\n", cases,
                              (n < 5 && n > 0) ? 1 : (n - 1) / 2);
    }

    return 0;
}
