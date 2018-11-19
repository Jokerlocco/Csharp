/*
Entrada

La entrada estará formada por distintos casos de prueba, cada uno representando 
la configuración de dientes de un día en la vida de la abuela María. El número 
total de casos aparece en la primera línea de la entrada.

Los casos siguen a continuación, cada uno formado por dos líneas. La primera 
contiene el alto de los seis dientes superiores responsables de la sonrisa 
(incisivos y caninos) de izquierda a derecha. De forma equivalente, la segunda 
línea contiene la información de los seis inferiores. Todos ellos son números 
enteros entre 0 y 2.000.

Salida

Para cada caso de prueba se escribirá SI si los dientes de arriba encajan 
perfectamente con los de abajo y no quedan huecos entre ninguno de ellos, o NO 
en caso contrario.

Entrada de ejemplo

2
1 3 1 3 1 3
3 1 3 1 3 1
1 1 1 1 1 1
1 2 1 1 1 1

Salida de ejemplo
SI
NO
*/

// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    int cases;
    cin >> cases;
    
    short row1[6];
    short row2[6];
    
    short sum;
    bool perfectSmile;
    
    for(int i = 0; i < cases; i++)
    {
        perfectSmile = true;
        
        for(int j = 0; j < 6; j++)
        {
            cin >> row1[j];
        }
        for(int j = 0; j < 6; j++)
        {
            cin >> row2[j];
        }
        
        sum = row1[0] + row2[0];
        
        for(int j = 1; j < 6; j++)
        {
            if(row1[j] + row2[j] != sum)
            {
                perfectSmile = false;
            }
        }
        
        if(perfectSmile)
        {
            cout << "SI" << endl;
        }
        else
        {
            cout << "NO" << endl;
        }
    }
}
