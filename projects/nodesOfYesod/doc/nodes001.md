# sv2018-programming

## Nodes Of Yesod 001

### Creating the skeleton

We must create a console C# project. When be run that empty project, a folder 
named "bin/debug" will be created, and we must put in that folder the DLLs we 
need:

```
jpeg.dll
libpng13.dll
SDL.dll
SDL_image.dll
SDL_mixer.dll
SDL_ttf.dll
Tao.Sdl.dll
zlib1.dll
```

Also, the file named "Tao.Sdl.dll" must be added to the "references" of our 
project (in the right column of Visual Studio: references, add reference, 
examine).

Then we must create a folder (or more), in which we'll place the images, fonts, 
sounds a game data. We can call it "data" and put in there a couple of images 
"player.png" and "enemy.png" and a font such as "joystix.ttf".

Finally, we must include the .cs example files (either with "Project / Add" 
class and copying + pasting the contents of each file, or with "Project / Add 
existing file"): 

* SdlHardware, to hide the (ugly?) details of SDL
* Image, to allow the easy load of images
* Sprite, to allow animated images (later)
* Font, to display texts using TrueType (ttf) fonts
* Game, the real game skeleton


### Using the skeleton

The look of the basic empty game is this:

```
using System;

class Game
{
    static void Main(string[] args)
    {
        bool fullScreen = false;
        SdlHardware.Init(1024, 768, 24, fullScreen);
        Font font18 = new Font("data/Joystix.ttf", 18);

        Image player = new Image("data/player.png");
        int playerX = 50;
        int playerY = 120;
        int playerSpeed = 8;
        int playerWidth = 32;
        int playerHeight = 64;

        Random rnd = new Random();
        int numEnemies = 2;
        int[] enemyX = new int[numEnemies];
        int[] enemyY = new int[numEnemies];
        int[] enemySpeedX = new int[numEnemies];
        for (int i = 0; i < numEnemies; i++)
        {
            enemyX[i] = rnd.Next(200, 800);
            enemyY[i] = rnd.Next(50, 600);
            enemySpeedX[i] = rnd.Next(1, 5);
        }
        int enemyWidth = 64;
        int enemyHeight = 64;
        Image enemy = new Image("data/enemy.png");

        bool finished = false;

        // Game Loop
        do
        {
            // Update screen
            SdlHardware.ClearScreen();

            SdlHardware.WriteHiddenText("Score: ",
                40, 10,
                0xCC, 0xCC, 0xCC,
                font18);

            SdlHardware.DrawHiddenImage(player, playerX, playerY);
            for (int i = 0; i < numEnemies; i++)
                SdlHardware.DrawHiddenImage(enemy, enemyX[i], enemyY[i]);
            SdlHardware.ShowHiddenScreen();


            // Check input by the user
            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
                playerX += playerSpeed;
            // TO DO: Complete with remaining keys

            if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
                finished = true;

            // Move enemies, background, etc 
            // TO DO

            // Check collisions and apply game logic
            // TO DO

            // Pause till next frame (40 ms = 25 fps)
            SdlHardware.Pause(40);
        }
        while (!finished);
    }
}
```

Let's see the details a bit more in depth:

* We will initialize the graphics mode using "SdlHardware.Init", which receives 
as parameters: screen width (such as 1024), screen height (768), colour depth 
(e.g. 24 bit) and full screen mode (*false* for windowed mode, *true* for full 
screen mode, not recommended while debugging).

```
SdlHardware.Init(1024, 768, 24, false);
```

We can create an image using Image name = new Image(fileName):

```
Image player = new Image("data/player.png");
```

Our images will be drawn in a hidden screen, and then dumped to the visible
screen, in order to minimize screen flickering ("double buffer"), so we will
usually do as follows:

```
SdlHardware.ClearScreen();
SdlHardware.DrawHiddenImage(player, x, y);
SdlHardware.ShowHiddenScreen();
```

Also, we can display text with:

```
SdlHardware.WriteHiddenText("Score: ",
    40, 10,
    0xCC, 0xCC, 0xCC,
    font18);
```

(parameters are: text, x, y, r-g-b for the color, font), and the font
would be loaded with:

```
Font font18 = new Font("data/Joystix.ttf", 18);
```

(parameters are: file, size)


We can check if any key is pressed with SdlHardware.KeyPressed(keyName):

```
if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
    x += 10;
```

And we can pause to achieve a certain amount of FPS (delay=20 ms for 50 fps) 
with


```
SdlHardware.Pause(20);
```

