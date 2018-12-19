// Adrián Navarro Gabino
// Next Round

/*
input 1
8 5
10 9 8 7 7 7 5 5

output 1
6

input 2
4 2
0 0 0 0
output 2
0
*/

#include <stdio.h>

int main()
{
    int players;
    int chosenPlayer;
    int i;
    
    scanf("%d", &players);
    scanf("%d", &chosenPlayer);
    
    int score[players];
    
    for(i = 0; i < players; i++)
    {
        scanf("%d", &score[i]);
    }
    
    int count = 0;
        
    for(int i = 0; i < players; i++)
    {
        if(score[i] >= score[chosenPlayer - 1] && score[i] > 0)
            count++;
    }
    
    printf("%d\n", count);

    return 0;
}
