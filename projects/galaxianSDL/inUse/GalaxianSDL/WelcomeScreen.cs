// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 009, 21-Feb-19   Nacho: Access to LoadingScreen, CreditsScreen and HelpScr
// 008, 04-Ene-19   Nacho: Extracted from class GalaxianSDL
// 007, 06-Dic-18   S. Ruescas: Created Welcome Screen

class WelcomeScreen
{
    private Image welcome;

    public WelcomeScreen()
    {
        welcome = new Image("data/welcome.png");
    }

    public void Run()
    {
        LoadingScreen ls = new LoadingScreen();
        ls.Run();

        // Display until the user presses SPC
        while ((SdlHardware.KeyPressed(SdlHardware.KEY_SPC) == false))
        {
            SdlHardware.ClearScreen();
            SdlHardware.DrawHiddenImage(welcome, 175, 0);
            SdlHardware.ShowHiddenScreen();

            SdlHardware.Pause(50); // So that we do not use a 100% CPU

            // The next is temporary, just to test the new classes
            // Some text should be shown
            if (SdlHardware.KeyPressed(SdlHardware.KEY_H))
            {
                HelpScreen hs = new HelpScreen();
                hs.Run();
            }
            if (SdlHardware.KeyPressed(SdlHardware.KEY_C))
            {
                CreditsScreen cs = new CreditsScreen();
                cs.Run();
            }
        }

        do
        {
            // Remove the SPC keypress
            // so that we do not fire right after entering the game
        }
        while (SdlHardware.KeyPressed(SdlHardware.KEY_SPC));
    }
}

