# sv2018-programming

## Galaxian Console 009

¿Qué hacer si queremos más de un "marciano"? Con lo que sabemos por ahora,
no hay más remedio que duplicar código: tendremos dos variables X, dos
velocidades (si queremos que se puedan mover de forma independiente), dos
rutinas de dibujado, dos de movimiento...

```
int xEnemy = 40;
int xEnemy2 = 30;
int enemySpeed = 2;
int enemySpeed2 = -3;

// ...

Console.SetCursorPosition(xEnemy, 10);
Console.WriteLine("W");

Console.SetCursorPosition(xEnemy2, 15);
Console.WriteLine("W");

// ...

// Update world
if ((xEnemy <= 5) || (xEnemy >= 75))
    enemySpeed = -enemySpeed;
xEnemy = xEnemy + enemySpeed;

if ((xEnemy2 <= 5) || (xEnemy2 >= 75))
    enemySpeed2 = -enemySpeed2;
xEnemy2 = xEnemy2 + enemySpeed2;

```


Claramente, no será la forma más eficiente cuando tengamos 5, o 10, o 30
"marcianos". Lo mejoraremos más adelante...
