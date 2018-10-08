# sv2018-programming

## Galaxian Console 002

Si queremos una nave que se pueda mover, el primer paso consiste en tener
una variable "x" para su posición:

```
Console.SetCursorPosition(x, 22);
Console.WriteLine("A");
```

Y en comprobar qué tecla se ha pulsado para cambiar esa coordenada "x"
según corresponda. De momento, en este primer contacto, usaremos las teclas
4 y 6 del teclado numérico para mover, y deberemos pulsar Intro tras esas
teclas, ya que emplearemos la orden "ReadLine()", que lee toda una línea de
texto, terminada con una pulsación de la tecla Intro.
            
```
int key = Convert.ToInt32(Console.ReadLine());
if( key == 4 )
    x = x - 3;
if( key == 6 )
    x = x + 3;
```
