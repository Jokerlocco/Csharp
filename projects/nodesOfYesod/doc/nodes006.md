# sv2018-programming

## Nodes Of Yesod 006

### Collisions + movement

Making the enemy move on its own is easy:

```
public override void Move()
{
    x += xSpeed;
    if ((x < 50) || (x > 970))
        xSpeed = -xSpeed;

}
```

And we can call it from Game:

```
void UpdateWorld()
{
    // Move enemies, background, etc 
    for (int i = 0; i < numEnemies; i++)
        enemies[i].Move();
}
```

Checking collisiones (using "bounding boxes") is already implemented in the
class Sprite. As both Player and Enemy inherit from Sprite, we can use it
in the class Game:

```
void CheckGameStatus()
{
    // Check collisions and apply game logic
    for (int i = 0; i < numEnemies; i++)
        if (player.CollisionsWith(enemies[i]))
            finished = true;
}
```


Also, as minor improvements, we can make the CreditsScreen display at least
an image and some text:

```
class CreditsScreen
{
    public void Run()
    {
        // TO DO
        Image welcome = new Image("data/welcome.png");
        Font font18 = new Font("data/Joystix.ttf", 18);
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(welcome, 0, 0);
        SdlHardware.WriteHiddenText("(Partial) Remake by Nacho",
            40, 10,
            0xCC, 0xCC, 0xCC,
            font18);
        SdlHardware.ShowHiddenScreen();
        SdlHardware.Pause(2000);
    }
}
```

And allow the user to choose an option in the WelcomeScreen:


```
class WelcomeScreen
{
    protected int option;

    public WelcomeScreen()
    {
        option = 0;
    }

    public int GetChosenOption()
    {
        return option;
    }

    public void Run()
    {
        // ...
        do
        {
            if (SdlHardware.KeyPressed(SdlHardware.KEY_1))
            {
                option = 1;
            }
            if (SdlHardware.KeyPressed(SdlHardware.KEY_2))
            {
                option = 2;
            }
            SdlHardware.Pause(100); // To avoid using 100% CPU
        }
        while (option == 0);
    }
}
```

And read this option from the main class (NodesOfYesod):

```
WelcomeScreen w = new WelcomeScreen();
w.Run();

if (w.GetChosenOption() == 1)
{
    Game g = new Game();
    g.Run();
}
else
{
    CreditsScreen credits = new CreditsScreen();
    credits.Run();
}
```

