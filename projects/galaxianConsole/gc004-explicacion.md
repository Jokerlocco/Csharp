# sv2018-programming

## Galaxian Console 004

Para que el "marciano" se mueva, basta con que su posición no esté prefijada, 
como en "Console.SetCursorPosition(40, 10);", sino que al menos una de sus 
coordenadas sea variable: "Console.SetCursorPosition(xEnemy, 10);".

Si queremos que inicialmente se mueva hacia la derechga, basta con incrmenetar 
su coordenada X en cada fotograma:

```
// Update world
xEnemy++;
```




