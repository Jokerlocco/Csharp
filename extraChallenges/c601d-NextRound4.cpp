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

#include <iostream>

using namespace std;

int main()
{
    int players;
    int chosenPlayer;
    
    cin >> players >> chosenPlayer;
    
    int score[players];
    
    for(int i = 0; i < players; i++)
    {
        cin >> score[i];
    }
    
    int count = 0;
        
    for(int i = 0; i < players; i++)
    {
        if(score[i] >= score[chosenPlayer - 1] && score[i] > 0)
            count++;
    }
    
    cout << count << endl;

    return 0;
}
