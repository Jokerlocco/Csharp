// Victor Tebar
// Sum of Digits

/*
Input sample
3433
64323
8
-1


Output sample
3 + 4 + 3 + 3 = 13
6 + 4 + 3 + 2 + 3 = 18
8 = 8
*/

#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
    string strNumber;
    int number;
    do{
        cin >> strNumber;
        number = atoi(strNumber.c_str());
        
        if(number > -1){
            int total = strNumber[0] - '0';
            cout << strNumber[0] << " ";
            
            for(unsigned int i=1;i < strNumber.length();++i){
                total += strNumber[i] - '0';
                cout << "+ " << strNumber[i] << " ";
            }
            
            cout << "= " << total << endl;
        }
    }while(number > -1);
}
