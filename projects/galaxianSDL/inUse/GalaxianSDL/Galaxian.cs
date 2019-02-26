// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 022, 26-Feb-19   Nacho: The menu in WelcomeScreen is really used
// 008, 04-Ene-19   Nacho: Split into classes
// 007, 06-Dic-18   S. Ruescas: Score, Welcome, EndSCreen, 2 sprites for enemies
// 006, 05-Dic-18   Nacho: Functions
// 005, 15-Nov-18   A.Navarro, C.Francés, K.Marín: Many enemies (struct)
// 004, 09-Nov-18   María Gonzáles: Many enemies
// 003, 25-Oct-18   Ivan Lazcano: Game can end, fire, enemies can die
// 002, 11-Oct-18   Jorge Calzada: Two enemys
// 001, 08-Oct-18   Nacho: Almost empty skeleton

public class GalaxianSDL
{
    public static void Main(string[] args)
    {
        SdlHardware.Init(1024, 768, 24, false);

        LoadingScreen ls = new LoadingScreen();
        ls.Run();

        WelcomeScreen welcome = new WelcomeScreen();
        do
        {
            welcome.Run();
            if (welcome.GetChosenOption() == WelcomeScreen.OPTION_PLAY)
            {
                Game g = new Game();
                g.Run();
                EndScreen end = new EndScreen();
                end.Run();
            }
            else if (welcome.GetChosenOption() == WelcomeScreen.OPTION_HELP)
            {
                HelpScreen help = new HelpScreen();
                help.Run();
            }
            else if (welcome.GetChosenOption() == WelcomeScreen.OPTION_CREDITS)
            {
                CreditsScreen credits = new CreditsScreen();
                credits.Run();
            }
            else if (welcome.GetChosenOption() == WelcomeScreen.OPTION_CONFIG)
            {
                ConfigScreen config = new ConfigScreen();
                config.Run();
            }
        }
        while (welcome.GetChosenOption() != WelcomeScreen.OPTION_QUIT);
    }
}
