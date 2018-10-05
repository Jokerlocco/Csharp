# sv2018-programming

## Galaxian Console 005

Si queremos que el "marciano" no se mueva sólo hacia la derecha, sino que 
"rebote" cada vez que toca un extremo horizontal, se puede hacer de varias formas.
Una de las más sencillas en cuanto a planteamiento, pero larga, es llevar un
"flag" (una variable de control que vale 0 ó 1). Según esa variable valga 0 o
1, moveremos el marciano hacia un lado u otro, así:


```
int movingToTheRight = 0;

// ...        

// Update world
if (movingToTheRight == 1)
{
    xEnemy++;
    if (xEnemy > 75)
        movingToTheRight = 0;
}

if (movingToTheRight == 0)
{
    xEnemy--;
    if (xEnemy < 5)
        movingToTheRight = 1;
}
```




