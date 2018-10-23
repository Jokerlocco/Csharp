//Ivan Lazcano Sindin
#include <stdio.h>

int main()
{
    int count;
    int altura = 0;
    scanf("%d", &count);
    for(int i = 0; i < count; i++)
    {
        scanf("%d", &altura);
        printf("%llu\n", altura*(altura+1LL)*(altura+2LL)/6LL);
        //Agregamos "LL" a los numeros para que sepa que queremos
        //trabajar con numberos "long long" que llegan justamente
        //a 10^18
    }
    return 0;
}
