//Ivan Lazcano Sindin

// Challenge 2.03: Calculation machine
// C version

/*
Example of input
5
5 + -13
10 / 2
7 * 3
3 / 0
5 - 13

Example of output
-8
5
21
ERROR
-8
*/

#include <stdio.h>

int main()
{
    int a, b;
    char operacion;
    int count;
    scanf("%d", &count);
    while(count--)
    {
        scanf("%d", &a);
        scanf("%s", &operacion);
        scanf("%d", &b);
        switch(operacion)
        {
            case '+':printf("%d\n", a+b);break;
            case '*':printf("%d\n", a*b);break;
            case '/':if(!b)printf("ERROR\n");else printf("%d\n", a/b);break;
            case '-':printf("%d\n", a-b);break;
        }
    }
}
