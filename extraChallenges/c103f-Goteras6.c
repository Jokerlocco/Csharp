// Challenge 1.03: "Goteras"

/*
Sample input
3
70
3600
3661
Sample output
00:01:10
01:00:00
01:01:01
*/

#include <stdio.h>

int main(void)
{
    int segundos, minutos, horas;
    int i, n, tiempo;
    
    scanf("%d", &n);
        
    for(i = 0; i < n; i++)
    {
        scanf("%d", &tiempo);
        
        horas = tiempo / 3600;
        
        if(horas < 10)
            printf("0");
        printf("%d:", horas);
        
        minutos = (tiempo % 3600) / 60;
        
        if(minutos < 10)
            printf("0");
        printf("%d:", minutos);
            
        segundos = tiempo - horas * 3600 - minutos * 60;
        
        if(segundos < 10)
            printf("0");
        printf("%d\n", segundos);
    }
    
    return 0;
}
