# sv2018-programming

## Galaxian Console 015

En vez de tener un array para las coordenadas X, otro para las coordenadas
Y, etc., podemos optar por crear un "struct" que agrupe todos los datos
de cada enemigo:

```
struct enemy
{
    public int x;
    public int y;
    public bool alive;
}
```

Así, ahora tendríamos un único array formado por elementos de ese nuevo
tipo:

```
int[] xEnemy = new int[SIZEENEMY];
int[] yEnemy = new int[SIZEENEMY];
bool[] enemyAlive = new bool[SIZEENEMY];
```



Si queremos muchos enemigos en vez de sólo 2, deja de ser planteable
usar variables individuales, y se convierte en necesario almacenar
los datos usando arrays.

Así, los datos de coordenadas de enemigos, así como si están vivos o no
pasarán a formar parte de arrays:

```
enemy[] e = new enemy [SIZEENEMY];

for ( int i = 0; i < SIZEENEMY; i++ )
{
    e[i].x = 10+3*i;
    e[i].y = 10;
    e[i].alive = true;
}
```


Y entonces cambiarán ligeramente las rutinas que antes usaban los tres
arrays. Por ejemplo, antes dibujábamos con:


```
for(int i = 0; i < SIZEENEMY; i++)
{
    if (enemyAlive[i])
    {
        Console.SetCursorPosition(xEnemy[i], yEnemy[i]);
        // ...
    }
}
```


y ahora usaremos

```
for(int i = 0; i < SIZEENEMY; i++)
{
    if (e[i].alive)
    {
        Console.SetCursorPosition(e[i].x, e[i].y);
        // ...
    }
}

```

