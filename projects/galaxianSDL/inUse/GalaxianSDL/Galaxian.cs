// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
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

        WelcomeScreen welcome = new WelcomeScreen();
        welcome.Run();

        Game game = new Game();
        game.Run();

        EndScreen end = new EndScreen();
        end.Run();
    }
}
