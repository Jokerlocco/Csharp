/*
Entrada de ejemplo

4
C-3PO
creador
Luke
padre
Princesa
Principe
Luke
Padre

Salida de ejemplo

C-3PO, yo soy tu creador
TOP SECRET
Princesa, yo soy tu Principe
Luke, yo soy tu Padre
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    int cases, i;
    scanf("%d", &cases);
    
    char name[101];
    char relationship[101];
    for(i = 0; i < cases; i++)
    {
        scanf("%s", name);
        scanf("%s", relationship);
        
        if ( (strcmp(name, "Luke") != 0) || 
            (strcmp(relationship, "padre") != 0 ))
        {
            printf("%s, yo soy tu %s\n", name, relationship);
        }
        else
        {
            printf("TOP SECRET\n");
        }
    }
}
