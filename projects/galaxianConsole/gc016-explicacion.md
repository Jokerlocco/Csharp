# sv2018-programming

## Galaxian Console 016

Vamos a descomponer el cuerpo del juego en funciones. Así, "Main" dejará
ver más claramente el bucle de juego:

```
public static void Main()
{
    Init();

    do
    {
        DrawElements();
        ProcessUserInput();
        UpdateWorld();
        CheckGameStatus();
        PauseUntilNextFrame();
    }
    while (!finished);

    DisplayFinalReport();
}
```

Ahora, los bloques lógicos como el dibujado de elementos en pantalla pasarán
a una nueva función:

```
public static void DrawElements()
{
    Console.Clear();
    for (int i = 0; i < SIZEENEMY; i++)
    {
        if (e[i].alive)
        {
            Console.SetCursorPosition(e[i].x, e[i].y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("W");
        }
    }

    Console.SetCursorPosition(xShip, 22);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("A");

    if (activeFire)
    {
        Console.SetCursorPosition(xFire, yFire);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("|");
    }
}

```

Pero hay variables que se deben compartir entre varias funciones, por lo que
pasarán a ser "globales". Deberemos dejarlas fuera de todas las funciones
y precederlas por la variable "static":

```
static enemy[] e;
static int xShip = 40;
static int speedForAllEnemies = 1;
static int xFire = xShip, yFire = 21;
static int fireSpeed = 1;
static bool activeFire = false;
static bool finished = false;
static int finishedCount = 0;
```

(Las constantes no necesitan el especificador "static":)

```
const int SIZEENEMY = 20;
```

Por el contrario, las variables que no sea necesario compartir deberán
ser locales, como la tecla que pulsa el usuario, que puede quedar dentro
de la función que comprueba las acciones del usuario:


```
public static void ProcessUserInput()
{
    ConsoleKeyInfo key;

    if (Console.KeyAvailable)
    {
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.LeftArrow)
            xShip = xShip - 3;
        if (key.Key == ConsoleKey.RightArrow)
            xShip = xShip + 3;
        if (key.Key == ConsoleKey.Escape)
            finished = true;
        if (key.Key == ConsoleKey.Spacebar)
        {
            xFire = xShip;
            activeFire = true;
        }
    }
}
```

