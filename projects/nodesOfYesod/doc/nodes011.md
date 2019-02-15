# sv2018-programming

## Nodes Of Yesod 011

### Three lives, slower animation

If we want our player to have 3 lives, we need a counter, either in Game,
or Player or the InfoPanel. For example, we might have it in the InfoPanel,
so it would be set in its consutructor:

```
class InfoPanel : Sprite
{
    protected Font font24;
    public int Lives { get; set; }

    public InfoPanel()
    {
        LoadImage("data/panel.png");
        x = 150;
        y = 620;
        font24 = new Font("data/Joystix.ttf", 24);
        Lives = 3;
    }

    public override void DrawOnHiddenScreen()
    {
        base.DrawOnHiddenScreen();
        SdlHardware.WriteHiddenText(Lives.ToString(),
            570, 640,
            0xC0, 0xC0, 0xC0,
            font24);
    }
}
```

and the Game would read and set its value:

```
for (int i = 0; i < room.NumEnemies; i++)
    if (player.CollisionsWith(room.Enemies[i]))
        finished = true;
    {
        panel.Lives--;
        room.Reload();
        // TO DO: Choose a per-room "safe position"
        player.MoveTo(200, 100); 
        if (panel.Lives <= 0)
            finished = true;
    }
```


Also (and not related), we can modify our class Sprite so that the
frames do not change so fast. We might add a setting from the amount of
"updatesPerFrame" that we want and a counter to know which "tick" are 
we in. For example, if our game runs at 40 FPS and we set updatesPerFrame = 4,
the image of the sprite will not change 40 times per second, but 40 / 4 = 10
times per second:


```
class Sprite
{
    // ...
    protected int updatesPerFrame;  // To change the image atfer several updates
    protected int currentFrameTick;

    public Sprite()
    {
        // ...
        updatesPerFrame = 3;
    }

    public void NextFrame()
    {
        if (!containsSequence)
            return;

        currentFrameTick++;
        if (currentFrameTick < updatesPerFrame)
            return;

        currentFrameTick = 0;
        // ...

```
