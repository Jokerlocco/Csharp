# sv2018-programming

## Galaxian Console 010

Si queremos que "finished" sea un booleano en vez de un entero, basta
con cambiar las líneas:


```
int finished = 0;

do
{
    // ...
    if (key.Key == ConsoleKey.Escape)
        finished = 1;

}
while (finished == 0);
```


por:

```
bool finished = false;

do
{
    // ...
    if (key.Key == ConsoleKey.Escape)
        finished = true;

}
while ( ! finished );
```

