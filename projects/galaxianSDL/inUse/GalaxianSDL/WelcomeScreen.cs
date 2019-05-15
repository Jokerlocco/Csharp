// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 029, 06-May-19   Nacho: Full screen can be toggled by pressing F2
// 022, 26-Feb-19   Nacho: Options are constants, used in galaxian.cs
// 018, 21-Feb-19   Enrique, Gonzalo: Menu for the game
// 009, 21-Feb-19   Nacho: Access to LoadingScreen, CreditsScreen and HelpScr
// 008, 04-Ene-19   Nacho: Extracted from class GalaxianSDL
// 007, 06-Dic-18   S. Ruescas: Created Welcome Screen

class WelcomeScreen
{
    private Image welcome;
    protected int option;
    protected Font font24;

    public const int OPTION_PLAY = 1;
    public const int OPTION_HELP = 2;
    public const int OPTION_CREDITS = 3;
    public const int OPTION_CONFIG = 4;
    public const int OPTION_QUIT = 5;

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
            option = 0;

            if (SdlHardware.KeyPressed(SdlHardware.KEY_1))
            {
                option = OPTION_PLAY;
            }

            if (SdlHardware.KeyPressed(SdlHardware.KEY_2))
            {
                option = OPTION_HELP;
            }

            if (SdlHardware.KeyPressed(SdlHardware.KEY_3))
            {
                option = OPTION_CREDITS;
            }
            if (SdlHardware.KeyPressed(SdlHardware.KEY_K))
            {
                option = OPTION_CONFIG;
            }

            if (SdlHardware.KeyPressed(SdlHardware.KEY_Q))
            {
                option = OPTION_QUIT;
            }

            if (SdlHardware.KeyPressed(SdlHardware.KEY_F2))
            {
                SdlHardware.ToggleFullScreen();
            }

            SdlHardware.Pause(50);
        }
        while (option == 0);
    }
}


