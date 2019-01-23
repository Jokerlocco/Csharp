/**
 * CreditsScreen.cs - Nodes Of Yesod, Credits screen
 * 
 * Changes:
 * 0.06, 23-01-2019: Displays an image and some text
 * 0.03, 14-01-2019: Credits screen created (empty skeleton)
 */

class CreditsScreen
{
    public void Run()
    {
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

