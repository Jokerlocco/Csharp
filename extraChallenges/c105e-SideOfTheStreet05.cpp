// Adrián Navarro Gabino
// Challenge 1.05: Side of the street

/*
Input sample
3
10
41
0

Output
IZQUIERDA
DERECHA
IZQUIERDA
*/

#include <iostream>

using namespace std;

int main()
{
    int streetNumber;
        
    do
    {
        cin >> streetNumber;
        
        if( (streetNumber != 0) && (streetNumber % 2 == 0) )
            cout << "DERECHA" << endl;
        else if (streetNumber % 2 == 1)
            cout << "IZQUIERDA" << endl;
    } while(streetNumber != 0);

	return 0;
}
