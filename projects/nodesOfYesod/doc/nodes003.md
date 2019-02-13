# sv2018-programming

## Nodes Of Yesod 003

### Classes

Now we are going to split the program into classes. A few of them will be
just skeletons:

```
class CreditsScreen
{
    public void Run()
    {
        // TO DO
    }
}
```

The main class now will be named NodesOfYesod and it will just launch
the WelcomeScreen and the Game:

```
class NodesOfYesod
{
    static void Main()
    {
        bool fullScreen = false;
        SdlHardware.Init(1024, 768, 24, fullScreen);

        WelcomeScreen w = new WelcomeScreen();
        w.Run();

        Game g = new Game();
        g.Run();
    }
}
```

The WelcomeScreen will simply display an image and wait for 2 seconds:

```
class WelcomeScreen
{
    public void Run()
    {
        Image welcome = new Image("data/welcome.png");
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(welcome, 0, 0);
        SdlHardware.ShowHiddenScreen();
        SdlHardware.Pause(2000);
    }
}
```

And Game will still be mostly as it was, but instead of Main, it will
contain a method named Run:

```
    public void Run()
    {
        Init();
        UpdateHighscore();
    }
```
