# sv2018-programming

## Galaxian Console 011

Añadir un disparo que siempre se mueve hacia arriba es muy similar a
un marciano que siempre se mueva hacia el lado:

Por una parte, necesitaremos una nueva variable para su coordenada Y, y
quizá otra para su velocidad (necesario si ésta puede cambiar, no tanto si
va a ser siempre la misma):

```
int yFire = 21;
int fireSpeed = 1;
```

A la hora de dibujar los elementos en pantalla, aparecerá uno más:

```
// Draw elements
// ...
Console.SetCursorPosition(40, yFire);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("|");
```

Y además deberemos actualizar su movimiento en cada fotograma, haciendo que
vuelva a la parte inferior de la pantalla cuando alcance el extremo superior:

```
// Update world
// ...
if (yFire <= 5)
    yFire = 21;
yFire = yFire - fireSpeed;

```


