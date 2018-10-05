# sv2018-programming

## Galaxian Console 006

Una forma alternativa de que el marciano "rebote" cada vez que toca un extremo 
horizontal, es no usar x++ en unos casos y x-- en otros casos, sino sumar 
siempre a su coordenada X una "velocidad", que será positiva cuando se deba 
mover a la derecha y negativa cuando se tenga que mover a la izquierda:

```
int enemySpeed = 2;

// ...        

// Update world
if ((xEnemy <= 5) || (xEnemy >= 75)) 
    enemySpeed = -enemySpeed;

xEnemy = xEnemy + enemySpeed;
```




