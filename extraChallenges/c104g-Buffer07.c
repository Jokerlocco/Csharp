/* 
Adrián Navarro Gabino
The buffer
*/

/*
How many men can use wall-mounted urinals at the same time without breaking
the rule that one must always leave a buffer between a urinal and other
urinal?
*/

/*
Example of entry:
5
1
2
3
4
5

Output for that example:
1
1
2
2
3
*/


#include <stdio.h>

int main(void)
{
    int cases, urinals, numberOfMen, i;
    
    scanf("%d", &cases);
        
    for(i = 0; i < cases; i++)
    {
        scanf("%d", &urinals);
        numberOfMen = urinals % 2 == 0 ? urinals / 2 : (urinals + 1) / 2;
        printf("%d\n", numberOfMen);
    }
    
    return 0;
}
