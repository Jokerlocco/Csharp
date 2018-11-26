//Sergio Ruescas
//Funciona con los casos de prueba pero en Acepta el reto me da WA
#include <iostream>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    string words, syllableEnd = "", syllableStart = "";
    bool chained;
    while(!cin.eof())
    {
        chained = true;
        getline(cin, words);
        for(unsigned int i = 0; i < words.length() ; i++)
        {

            if (words[i] == ' ')
            {
                if ( i == words.length() - 1)
                    break;
                syllableEnd += words[i - 2];
                syllableEnd += words[i - 1];
                syllableStart += words[i + 1];
                syllableStart += words[i + 2];
                if ( syllableEnd == syllableStart )
                    chained = true;
                else
                {
                    chained = false;
                    break;
                }
            }
           
        }
        if( chained )
            printf("SI\n");
        else
            printf("NO\n");
        syllableEnd = "";
        syllableStart = "";
    }
}

