/*
Challenge 1.01: The watermelon
Can the watermelon be split in two pieces, weighting an even
number of kilos each? (Codeforces 4A)

Sample input 1
4

Sample output 1
YES

Sample input 2
3

Sample output 2
NO
*/

#include <iostream>

using namespace std;

int main()
{
    int weight;
    cin >> weight;
    
    if (( weight > 2 ) && ( weight % 2 == 0 ))
        cout << "YES" << endl;
    else
        cout << "NO" << endl;
        
    return 0;
}
