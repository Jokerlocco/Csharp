// El hombre sin miedo y sin radar
// Iva Lazcano
// https://www.aceptaelreto.com/problem/statement.php?id=479

/* 
Entrada de ejemplo

3 8
.X....X.
...X....
....X...
3
3 2 ARRIBA
2 1 DERECHA
1 1 ABAJO
0 0

Salida de ejemplo

2
3
NINGUNO
---

*/


#include <iostream>
using namespace std;

int main()
{
    int filas, columnas, casos;
    int x, y;
    string direccion;
    
    cin >> filas >> columnas;
    while(filas != 0 || columnas != 0)
    {
        char mapa[filas][columnas];
        
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                mapa[i][j] = getchar();
                if(mapa[i][j] == '\n')
                    mapa[i][j] = getchar();
            }
        }
        
        cin >> casos;
        
        for(;casos > 0; casos--)
        {
            cin >> x >> y >> direccion;
    
            x--;y--;
            if(direccion == "ARRIBA")
            {
                for (int i = x;;)
                {
                    x--;
                    if(x < 0)
                    {
                        cout << "NINGUNO" << "\n";
                        break;
                    }
                    else if(mapa[x][y] == 'X')
                    {
                        cout << (i-x) << "\n";
                        break;
                    }
                }
            }
            else if(direccion == "ABAJO")
            {
                for (int i = x;;)
                {
                    x++;
                    if(x >= filas)
                    {
                        cout << "NINGUNO" << "\n";
                        break;
                    }
                    else if(mapa[x][y] == 'X')
                    {
                        cout << (x-i) << "\n";
                        break;
                    }
                }
            }
            else if(direccion == "DERECHA")
            {
                for (int i = y;;)
                {
                    y++;
                    if(y >= columnas)
                    {
                        cout << "NINGUNO" << "\n";
                        break;
                    }
                    else if(mapa[x][y] == 'X')
                    {
                        cout << (y-i) << "\n";
                        break;
                    }
                }
            }
            else if(direccion == "IZQUIERDA")
            {
                for (int i = y;;)
                {
                    y--;
                    if(y < 0)
                    {
                        cout << "NINGUNO" << "\n";
                        break;
                    }
                    else if(mapa[x][y] == 'X')
                    {
                        cout << (i-y) << "\n";
                        break;
                    }
                }
            }
        }
        cout << "---" << "\n";
        cin >> filas >> columnas;
    }
    return 0;
}
