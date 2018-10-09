// Adrián Navarro Gabino
// Challenge 1.06 - Counting in the sand (acepta 369)

/*
Counting in base 1

Example input
1
4
6
0

Example output
1
1111
111111
*/


#include <iostream>

using namespace std;

int main()
{
    int n;
        
    do
    {
        cin >> n;
        
        if (n != 0)
        {
            for(int i = 0; i < n; i++)
                cout << 1;
            cout << endl;
        }
    } while(n != 0);

	return 0;
}
