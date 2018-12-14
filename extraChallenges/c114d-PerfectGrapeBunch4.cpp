// Adrián Navarro Gabino

#include <iostream>
#include <math.h>

using namespace std;

int main()
{
    int grapes;
    
    do
    {
        cin >> grapes;
        
        if(grapes != 0)
        {
            double level = (-1 + sqrt(1 + 8 * grapes)) / 2;
            
            cout << (int)ceil(level) << endl;
        }
    }while(grapes != 0);
    
    return 0;
}
