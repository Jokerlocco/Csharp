// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
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
        // Display until the user presses SPC
        while ((SdlHardware.KeyPressed(SdlHardware.KEY_SPC) == false))
        {
            SdlHardware.ClearScreen();
            SdlHardware.DrawHiddenImage(welcome, 175, 0);
            SdlHardware.ShowHiddenScreen();

            SdlHardware.Pause(50); // So that we do not use a 100% CPU
        }

        do
        {
            // Remove the SPC keypress
            // so that we do not fire right after entering the game
        }
        while (SdlHardware.KeyPressed(SdlHardware.KEY_SPC));
    }
}

