//Ivan Lazcano Sindin
//primera aproximación, muy lento con el for y operaciones innecesarias
#include <stdio.h>

int main()
{
    int count, j;
    unsigned long long canicas = 0;
    unsigned long long last = 0;
    int altura = 0;
    scanf("%d", &count);
    for(int i = 0; i < count; i++)
    {
        scanf("%d", &altura);
        canicas = 0;
        last = 0;
        for( j = 1; j <= altura; j++)
        {
            
            canicas += j + last;
            last += j;
        }
        printf("%llu\n", canicas);
    }
    return 0;
}
