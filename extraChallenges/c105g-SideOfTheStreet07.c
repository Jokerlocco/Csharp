/*
Adrián Navarro Gabino
Challenge 1.05: Side of the street
*/

/*
Input sample
3
10
41
0

Output
IZQUIERDA
DERECHA
IZQUIERDA
*/


#include <stdio.h>

int main(void)
{
    int streetNumber;
    
    do
    {
        scanf("%d", &streetNumber);
            
        if( (streetNumber != 0) && (streetNumber % 2 == 0) )
            printf("DERECHA\n");
        else if (streetNumber % 2 == 1)
            printf("IZQUIERDA\n");
    } while(streetNumber != 0);
    
    return 0;
}
