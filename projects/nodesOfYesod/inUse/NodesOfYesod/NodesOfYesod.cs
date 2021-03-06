﻿/**
 * NodesOfYesod.cs - Nodes Of Yesod, main class
 * 
 * Changes:
 * 0.10, 10-02-2019: Help screen can be displayed
 * 0.07, 25-01-2019: Repeated until Q is pressed
 * 0.03, 14-01-2019: Main & Hardware init moved from Game. Added WelcomeScreen
 */

class NodesOfYesod
{
    static void Main()
    {
        bool fullScreen = false;
        SdlHardware.Init(1024, 768, 24, fullScreen);

        WelcomeScreen w = new WelcomeScreen();
        do
        {
            w.Run();
            if (w.GetChosenOption() == WelcomeScreen.OPTION_PLAY)
            {
                Game g = new Game();
                g.Run();
            }
            else if (w.GetChosenOption() == WelcomeScreen.OPTION_HELP)
            {
                HelpScreen help = new HelpScreen();
                help.Run();
            }
            else if (w.GetChosenOption() == WelcomeScreen.OPTION_CREDITS)
            {
                CreditsScreen credits = new CreditsScreen();
                credits.Run();
            }
        }
        while (w.GetChosenOption() != WelcomeScreen.OPTION_QUIT);
    }
}
