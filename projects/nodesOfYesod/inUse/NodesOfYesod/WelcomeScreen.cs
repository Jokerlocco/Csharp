﻿/**
 * WelcomeScreen.cs - Nodes Of Yesod, Welcome screen
 * 
 * Changes:
 * 0.07, 25-01-2019: Text in a different position. Q to Quit
 * 0.06, 23-01-2019: Two options can be chosen
 * 0.03, 14-01-2019: Welcome screen created (image displayed for 2 secs)
 */

class WelcomeScreen
{
    protected Image welcome;
    protected int option;
    protected Font font24;

    public WelcomeScreen()
    {
        welcome = new Image("data/welcome.png");
        option = 0;
        font24 = new Font("data/Joystix.ttf", 24);
    }

    public int GetChosenOption()
    {
        return option;
    }

    public void Run()
    {
        option = 0;
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(welcome, 0, 0);

        SdlHardware.WriteHiddenText("1. Play",
            490, 590,
            0xC0, 0xC0, 0xC0,
            font24);
        SdlHardware.WriteHiddenText("2. Credits",
            490, 630,
            0xA0, 0xA0, 0xA0,
            font24);
        SdlHardware.WriteHiddenText("Q. Quit",
            490, 670,
            0x80, 0x80, 0x80,
            font24);

        SdlHardware.ShowHiddenScreen();

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
            if (SdlHardware.KeyPressed(SdlHardware.KEY_Q))
            {
                option = 3;
            }
            SdlHardware.Pause(100); // To avoid using 100% CPU
        }
        while (option == 0);
    }
}

