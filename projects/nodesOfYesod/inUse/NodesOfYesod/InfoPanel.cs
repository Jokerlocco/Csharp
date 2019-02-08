/**
 * InfoPanel.cs - Nodes Of Yesod, Information panel
 * 
 * Changes:
 * 0.10, 08-02-2019: Class created, only displays the background image
 */

class InfoPanel : Sprite
{
    public InfoPanel()
    {
        LoadImage("data/panel.png");
        x = 150;
        y = 620;
    }
}

