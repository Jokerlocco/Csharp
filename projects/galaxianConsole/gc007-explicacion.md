# sv2018-programming

## Galaxian Console 007

Es deseable que los "marcianos" se puedan mover de forma independiente de 
nuestra nave. El problema es que "Console.ReadKey()", tal como lo hemos usado, 
es "bloqueante": detiene el programa por completo hasta que se pulse una tecla.

Afortunadamente, existe una forma de evitarlo: tenemos a nuestra disposición un 
"Console.KeyAvailable", que no bloquea el programa y que será "verdadero" 
cuando haya alguna tecla que comprobar, y "falso" cuando no se haya pulsado 
ninguna, con lo que el fragmento de programa que comprueba si se debe mover nuestra
nave será:

```
// Process user input
if (Console.KeyAvailable)
{
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.LeftArrow)
        xShip = xShip - 3;
    if (key.Key == ConsoleKey.RightArrow)
        xShip = xShip + 3;
    if (key.Key == ConsoleKey.Escape)
        finished = 1;
}
```

(Ahora el movimiento será demasiado rápido, no resultará jugable, y además, por 
culpa de los parpadeos de la consola, prácticamente no se verá nada; lo 
solucionaremos con la siguiente mejora).


