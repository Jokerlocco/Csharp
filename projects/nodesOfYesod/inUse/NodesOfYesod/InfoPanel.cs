/**
 * InfoPanel.cs - Nodes Of Yesod, Information panel
 * 
 * Changes:
 * 0.11, 08-02-2019: Amount of lives is displayed (starts with 3)
 * 0.10, 08-02-2019: Class created, only displays the background image
 */

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

