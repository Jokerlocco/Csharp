//Ivan Lazcano Sindin

/*
Entrada de ejemplo
2
1 1 1 1 15
2 3 1 4 52

Salida de ejemplo
54
462
*/

#include <stdio.h>

int main()
{
    int insectos, aracnidos, crustaceos, escolopendras, anillos;
    int count;
    scanf("%d", &count);
    while(count--)
    {
        scanf("%d", &insectos);
        scanf("%d", &aracnidos);
        scanf("%d", &crustaceos);
        scanf("%d", &escolopendras);
        scanf("%d", &anillos);
        printf("%d\n", insectos * 6 + aracnidos * 8 + crustaceos * 10 +
         anillos * 2 * escolopendras);
        
    }
    return 0;
}
