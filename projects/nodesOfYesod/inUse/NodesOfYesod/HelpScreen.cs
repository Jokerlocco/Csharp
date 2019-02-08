/**
 * HelpScreen.cs - Nodes Of Yesod, Help screen
 * 
 * Changes:
 * 0.10, 08-02-2019: Displays the background image and some text
 * 0.03, 14-01-2019: Help screen created (empty skeleton)
 */

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

