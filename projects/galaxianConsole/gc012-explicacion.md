# sv2018-programming

## Galaxian Console 012

Podemos hacer que el disparo no esté siempre activo, sino sólo cuando se 
pulse la barra espaciadora. 

Necesitaremos un boolean para comprobar si está activo o no:

```
bool activeFire = false;
```

Y no dibujaremos siempre el disparo, sino sólo si está activo:

```
if (activeFire)
{
    Console.SetCursorPosition(40, yFire);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("|");
}
```

El disparo se activará cuando se pulse espacio:

```
if (key.Key == ConsoleKey.Spacebar)
    activeFire = true;
```

Y se desactivará cuando alcance la parte superior de la pantalla:

```
if (yFire <= 2)
{
    yFire = 21;
    activeFire = false;
}
```

De igual modo, sólo nos preocuparemos de actualizar la posición del disparo 
cuando realmente esté activo:

```
if (activeFire)
    yFire = yFire - fireSpeed;
```
