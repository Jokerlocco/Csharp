/**
 * CreditsScreen.cs - Nodes Of Yesod, Credits screen
 * 
 * Changes:
 * 0.07, 25-01-2019: 
 *    Image differs from WelcomeScreen
 *    Text centered
 *    R to Return, instead of timer
 * 0.06, 23-01-2019: Displays an image and some text
 * 0.03, 14-01-2019: Credits screen created (empty skeleton)
 */

class CreditsScreen
{
    public void Run()
    {
        Image welcome = new Image("data/credits.png");
        Font font18 = new Font("data/Joystix.ttf", 18);
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(welcome, 0, 0);
        SdlHardware.WriteHiddenText("(Partial) Remake by Nacho",
            360, 430,
            0xCC, 0xCC, 0xCC,
            font18);
        SdlHardware.WriteHiddenText("R to Return",
            460, 470,
            0xBB, 0xBB, 0xBB,
            font18);
        SdlHardware.ShowHiddenScreen();

        do
        {
            SdlHardware.Pause(100); // To avoid using 100% CPU
        }
        while (! SdlHardware.KeyPressed(SdlHardware.KEY_R));
    }
}

