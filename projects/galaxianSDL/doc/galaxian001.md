# sv2018-programming

## Galaxian Console 001

We are going to use an auxiliary class, named SdlHardware, to hide a few details
of the internal usage of SDL.

With this class. we would initialize the graphics mode using "SdlHardware.Init",
which receives as parameters: screen width, screen height, colour depth and
full screen mode (*false* for windowed mode, *true* for full screen mode, not
recommended while debugging).

```
SdlHardware.Init(1024, 768, 24, false);
```

We can create an image using Image name = new Image(fileName):

```
Image enemy1 = new Image("data/enemy1a.png");
```

Our images will be drawn in a hidden screen, and then dumped to the visible
screen, in order to minimize screen flickering ("double buffer"), so we will
usually do as follows:

```
SdlHardware.ClearScreen();
SdlHardware.DrawHiddenImage(enemy1, xEnemy, 200);
SdlHardware.ShowHiddenScreen();
```

We can check if any key is pressed with SdlHardware.KeyPressed(keyName):

```
if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
    xShip += 10;
```


And we can pause to achieve a certain amount of FPS (50 fps if delay=20 ms) with


```
SdlHardware.Pause(20);
```


So the full source for this skeleton will be:

```
public class GalaxianSDL
{
    public static void Main(string[] args)
    {

        SdlHardware.Init(1024, 768, 24, false);

        int xShip = 500;
        int xEnemy = 400;
        int enemySpeed = 5;
        int finished = 0;

        Image ship = new Image("data/ship.png");
        Image enemy1 = new Image("data/enemy1a.png");

        do
        {
            // Draw elements
            SdlHardware.ClearScreen();
            SdlHardware.DrawHiddenImage(enemy1, xEnemy, 200);
            SdlHardware.DrawHiddenImage(ship, xShip, 500);
            SdlHardware.ShowHiddenScreen();

            // Process user input
            if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
                finished = 1;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
                xShip += 10;
            
            // Update world
            xEnemy += enemySpeed;

            // Check game status
            // (Not yet)

            // Pause until next frame
            SdlHardware.Pause(20);
        }
        while (finished == 0);
    }
}
```

