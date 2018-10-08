# sv2018-programming

## Galaxian Console 003

ReadLine obliga a pulsar Intro después de teclear cualquier dato. Una alternativa
más adecuada para juegos es emplear "Console.ReadKey", que espera una única
pulsación de tecla.

Los cambios afectarán a la forma de declarar la variable "tecla" ("key") y
de comprobar los posibles valores:

```
ConsoleKeyInfo key;

// ...
        
key = Console.ReadKey();
if (key.Key == ConsoleKey.LeftArrow)
    x = x - 3;
if (key.Key == ConsoleKey.RightArrow)
    x = x + 3;
```

