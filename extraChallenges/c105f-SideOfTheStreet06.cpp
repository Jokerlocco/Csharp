//Sergio Ruescas
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
    int numero;
    cin >> numero;
    
    while (numero != 0)
    {
            if (numero % 2 == 0)
                cout<<"DERECHA"<<endl;
            else 
                cout<<"IZQUIERDA"<<endl;                
            cin >> numero;
    } 
}
