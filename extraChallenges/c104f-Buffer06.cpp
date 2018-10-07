// Adrián Navarro Gabino

/*
How many men can use wall-mounted urinals at the same time without breaking
the rule that one must always leave a buffer between a urinal and other
urinal?
*/

/*
Example of entry:
5
1
2
3
4
5

Output for that example:
1
1
2
2
3
*/


#include <iostream>

using namespace std;

int main()
{
    int cases, urinals, numberOfMen, i;
    
    cin >> cases;
        
    for(int i = 0; i < n; i++)
    {
        cin >> urinals;
        numberOfMen = urinals % 2 == 0 ? urinals / 2 : (urinals + 1) / 2;
        cout << segundos << endl;
    }

	return 0;
}
