/**
 * WelcomeScreen.cs - Nodes Of Yesod, Welcome screen
 * 
 * Changes:
 * 0.03, 14-01-2019: Welcome screen created (image displayed for 2 secs)
 */

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

