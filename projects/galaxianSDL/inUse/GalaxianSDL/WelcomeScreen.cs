// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 018, 21-Feb-19   Enrique, Gonzalo: Menu for the game
// 009, 21-Feb-19   Nacho: Access to LoadingScreen, CreditsScreen and HelpScr
// 008, 04-Ene-19   Nacho: Extracted from class GalaxianSDL
// 007, 06-Dic-18   S. Ruescas: Created Welcome Screen

class WelcomeScreen
{
    private Image welcome;
    protected int option;
    protected Font font24;

    public WelcomeScreen()
    {
        welcome = new Image("data/welcome.png");
        option = 0;
        font24 = new Font("data/Joystix.ttf", 40);
    }

    public int GetChosenOption()
    {
        return option;
    }

    public void Run()
    {
        LoadingScreen ls = new LoadingScreen();
        ls.Run();

        Image menu = new Image("data/background.png");
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(menu, 160, 60);
        SdlHardware.WriteHiddenText("1. Play",
            380, 240,
            0xC0, 0xC0, 0xC0,
            font24);
        SdlHardware.WriteHiddenText("2. Help",
            380, 280,
            0xA0, 0xA0, 0xA0,
            font24);
        SdlHardware.WriteHiddenText("3. Credits",
            380, 320,
            0xA0, 0xA0, 0xA0,
            font24);
        SdlHardware.WriteHiddenText("K. Config",
            380, 360,
            0xA0, 0xA0, 0xA0,
            font24);
        SdlHardware.WriteHiddenText("Q. Quit",
            380, 400,
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
            if (SdlHardware.KeyPressed(SdlHardware.KEY_3))
            {
                option = 3;
            }
            if (SdlHardware.KeyPressed(SdlHardware.KEY_K))
            {
                option = 4;
                // ConfigurationScreen sc = new ConfigurationScreen();
                // cs.Run();
            }

            if (SdlHardware.KeyPressed(SdlHardware.KEY_Q))
            {
                option = 5;
            }
            SdlHardware.Pause(100);
        }
        while (option == 0);
    }
}


