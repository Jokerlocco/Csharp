//Ivan Lazcano Sindin
//Puesto 11 con un tiempo de 0.02
#include <stdio.h>
#define gc getchar_unlocked

void scanint(int &x)
{
    register int c = gc();
    x = 0;
    for(;(c<48 || c>57);c = gc());
    for(;c>47 && c<58;c = gc()) {x = (x<<1) + (x<<3) + c - 48;}
}

int main()
{
    int count;
    int altura = 0;
    scanint(count);
    for(int i = 0; i < count; i++)
    {
        scanint(altura);
        printf("%llu\n", altura*(altura+1LL)*(altura+2LL)/6LL);
        //Agregamos "LL" a los numeros para que sepa que queremos
        //trabajar con numberos "long long" que llegan justamente
        //a 10^18
    }
    return 0;
}
