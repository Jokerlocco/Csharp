/* 
Challenge 1.06 - Counting in the sand (acepta 369)
Ivan Lazcano
*/

/*
Counting in base 1

Example input
1
4
6
0

Example output
1
1111
111111
*/

#include <stdio.h>

int main()
{
    int count, i;
    scanf("%d", &count);
    while(count)
    {
        for(i = 0; i < count; i++)
            printf("1");
        printf("\n");
        scanf("%d", &count);
        
    }
    return 0;
}
