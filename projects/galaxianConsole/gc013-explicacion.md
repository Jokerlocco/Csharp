# sv2018-programming

## Galaxian Console 013

Para comprobar colisiones entre disparo y enemigos, la idea básica es
que tendremos que comprobar si las coordenadas del disparo y de (cada)
enemigo coinciden. Si eso ocurre, marcaremos el enemigo como "no activo"
para que no se dibuje más (ni se comprueben colisiones, ni se actualice
su movimiento...)

```
if (yEnemy1 == yFire && xEnemy1 == xFire)
    enemy1Alive = false;

if (yEnemy1 == yFire && xEnemy2 == xFire)
    enemy2Alive = false;
```

Eso supone que, para mayor legibilidad y para que posibles cambios posteriores
sean más sencillos, las coordenadas Y de los marcianos, estarían mejor en
variables que como "números mágicos":

```
int xEnemy1 = 40, yEnemy1 = 10;
int xEnemy2 = 30, yEnemy2 = 15;
```


y que necesitaremos esos 2 booleanos adicionales para saber si cada uno 
de los marcianos está "activo" o no:

```
bool enemy1Alive = true;
bool enemy2Alive = true;
```

Además, la partida hasta ahora sólo terminaba cuando se pulsaba la tecla
ESC, pero ya podemos añadir la posibilidad de que acabe si destruimos a los
dos enemigos

```
if (!enemy1Alive && !enemy2Alive)
    finished = true;
```

Y, como ya hemos anticipado, sólo dibujaremos los enemigos si están "activos":

```
if (enemy1Alive)
{
    Console.SetCursorPosition(xEnemy1, yEnemy1);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("W");
}
```

Una mejora adicional que es muy sencilla de hacer y que ayuda a que el juego
sea "más real" es que los disparos no salgan siempre desde una posición
prefijada, sino desde donde se encuentra nuestra nave:

```
if (key.Key == ConsoleKey.Spacebar)
{
    xFire = xShip;
    activeFire = true;
}
```

E incluso podemos aprovechar para mejorar otro detalle que no va a ser importante
todavía, pero sí lo podría ser cuando obtengamos puntos por cada enemigo
destruido, especialmente en modo gráfico, donde las colisiones pueden ocurrir
durante más de un fotograma: si un enemigo no está activo, no se debería
comprobar colisiones con él...

```
if (enemy1Alive && yEnemy1 == yFire && xEnemy1 == xFire)
    enemy1Alive = false;

if (enemy2Alive && yEnemy1 == yFire && xEnemy2 == xFire)
    enemy2Alive = false;
```

