/*
Challenge 1.01: The watermelon
Can the watermelon be split in two pieces, weighting an even
number of kilos each? (Codeforces 4A)

Sample input 1
4

Sample output 1
YES

Sample input 2
3

Sample output 2
NO
*/

#include <stdio.h>

int main()
{
    int weight;
    scanf("%d", &weight);
    
    if (( weight > 2 ) && ( weight % 2 == 0 ))
        printf("YES\n");
    else
        printf("NO\n");
        
    return 0;
}
