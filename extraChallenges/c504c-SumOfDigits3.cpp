// Adrián Navarro Gabino
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
#include <string>

using namespace std;

int main()
{
    string number;
    int digit;

    do
    {
        int sum = 0;
        cin>> number;

        if(number[0] != '-')
        {
            for(unsigned int i = 0; i < number.length() - 1; i++)
            {
                digit = (int)number[i] - '0';
                sum += digit;
                cout << digit << " + ";
            }

            digit = (int)number[number.length() - 1] - '0';
            sum += digit;
            cout << digit << " = " << sum << endl;
        }
    } while(number[0] != '-');

    return 0;
}
