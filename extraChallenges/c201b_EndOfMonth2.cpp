//Sergio Ruescas
// Reto 2.01: Fin de mes

/*
Entrada de ejemplo
8
100 -10
-10 -100
-10 100
100 -1000
2500 -2490
9500 -9500
-100 99
50 -50

Salida de ejemplo
SI
NO
SI
NO
SI
SI
NO
SI
*/

#include <iostream>
using namespace std;

int main()
{
    int primero, ultimo, casos;
    scanf("%d", &casos);
    for (int i = 0; i < casos ; i++)
    {
        scanf("%d %d", &primero, &ultimo);
        
        if(ultimo + primero < 0)
            printf("NO\n");
        else
            printf("SI\n");
    }
    return 0;
}

