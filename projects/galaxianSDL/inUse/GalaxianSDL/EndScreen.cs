// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 008, 04-Ene-19   Nacho: Extracted from class GalaxianSDL, only one text
// 007, 06-Dic-18   S. Ruescas: Created End Screen

class EndScreen
{
    private Font font18;

    public EndScreen()
    {
        font18 = new Font("data/Joystix.ttf", 18);
    }

    public void Run()
    {
        SdlHardware.Pause(1000);

        SdlHardware.ClearScreen();
        SdlHardware.WriteHiddenText("Game over!",
            400, 300,
            0xCC, 0xCC, 0xCC,
            font18);
            SdlHardware.ShowHiddenScreen();

        SdlHardware.Pause(2000);
    }
}

