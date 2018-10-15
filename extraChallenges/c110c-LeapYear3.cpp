// Jorge Calzada Asenjo
// Challenge 1.10: Gregory XIII
// C++ version

/*
    Calculate how many days you have in February in a given year
*/

/*
Example of input
4
1584
1600
1699
1700


Example of output
29
29
28
28
*/

#include <iostream>

using namespace std;

int main()
{
    int cases, year;

    cin >> cases;

    for (int i = 0; i < cases; i++)
    {
        cin >> year;

        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            cout << 29 << endl;
        } else {
            cout << 28 << endl;
        }
    }

    return 0;
}
