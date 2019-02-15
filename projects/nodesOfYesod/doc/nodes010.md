# sv2018-programming

## Nodes Of Yesod 010

### Help Screen

We are going to create Help Screen, which will display some text (taken from
an array of strings):

```
class HelpScreen
{
    public void Run()
    {
        string[] text =
        {
            "Use arrow keys to move right or left",
            "Use spacebar to jump",
            "Arrows + spacebar to jump sidewards",
            "Beware of the moving enemies",
            "Press Q to quit the game",
            " ",
            "Press R to Return"
        };

        Image background = new Image("data/help.png");
        Font font18 = new Font("data/Joystix.ttf", 18);
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(background, 0, 0);

        byte grey = 200;
        short x = 300;
        short y = 250;
        short spacing = 40;
        for (int i = 0; i < text.Length; i++)
        {
            SdlHardware.WriteHiddenText(text[i],
                x, y,
                grey, grey, grey,
                font18);
            grey -= 20;
            y += spacing;
        }
        SdlHardware.ShowHiddenScreen();

        do
        {
            SdlHardware.Pause(100); // To avoid using 100% CPU
        }
        while (!SdlHardware.KeyPressed(SdlHardware.KEY_R));
    }
}
```

Also, we might create constants in order to make WelcomeScreen more readable:

```
class WelcomeScreen
{
    public const int OPTION_PLAY = 1;
    public const int OPTION_HELP = 2;
    public const int OPTION_CREDITS = 3;
    public const int OPTION_QUIT = 4;
    
    // ...
    
```

And return those constants from the method Run:

```
if (SdlHardware.KeyPressed(SdlHardware.KEY_Q))
{
    option = OPTION_QUIT;
}
```


The usage from NodesOfYesod.cs would not be very different from now:: 

```
if (w.GetChosenOption() == WelcomeScreen.OPTION_HELP)
{
    HelpScreen help = new HelpScreen();
    help.Run();
}
```

And we can also create a class named InfoPanel, which currently will only
display an image but soon will show the amount of lives, energy, items
collected and so on...

```
class InfoPanel : Sprite
{
    public InfoPanel()
    {
        LoadImage("data/panel.png");
        x = 150;
        y = 620;
    }
}
```

And we will display it in the Game



```
protected InfoPanel panel;

public Game()
{
    // ...
    panel = new InfoPanel();
}

// ...

void UpdateScreen()
{
    SdlHardware.ClearScreen();
    // ...
    panel.DrawOnHiddenScreen();
    SdlHardware.ShowHiddenScreen();
}
```

