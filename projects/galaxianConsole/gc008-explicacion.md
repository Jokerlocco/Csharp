# sv2018-programming

## Galaxian Console 008

Ahora el "marciano" se mueve aunque nosotros no toquemos ninguna tecla,
pero demasiado deprisa. Una forma sencilla de solucionarlo es añadir una pausa
al final de cada fotograma. Por ejemplo, si esa pausa es de 100 milisegundos,
el juego ira a (casi) 10 fotogramas por segundo.

Esa pausa se puede hacer con:

```
// Pause until next frame
Thread.Sleep(100);
```


que necesita un nuevo "using":

```
using System.Threading;
```

