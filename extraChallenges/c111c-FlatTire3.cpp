// Adrián Navarro Gabino

#include <iostream>


using namespace std;

int main()
{
    int cases;
    int start, prick;
    
    cin >> cases;

    for(int i = 0; i < cases; i++)
    {
        cin >> start >> prick;
        
        prick -= start;

        if(prick == 0 || prick == 180 || prick == -180)
        {
            cout << "DA IGUAL" << endl;
        }
        else if((prick > 0 && prick < 180) || (prick < -180 && prick > -360))
        {
            cout << "ASCENDENTE" << endl;
        }
        else
        {
            cout << "DESCENDENTE" << endl;
        }
        
    }

	return 0;
}
