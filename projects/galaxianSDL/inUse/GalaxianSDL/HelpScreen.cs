// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023, 12-Mar-19   Nacho: Some text is displayed
// 009, 21-Feb-19   Nacho: Empty skeleton

class HelpScreen
{
    Font font18;

    public HelpScreen()
    {
        font18 = new Font("data/Joystix.ttf", 18);
    }

    public void Run()
    {
        // TO DO: Display some Help. Wait for R to return.
        SdlHardware.Pause(1000);

        SdlHardware.ClearScreen();
        SdlHardware.WriteHiddenText("Help soon available",
            200, 100,
            0xCC, 0xCC, 0xCC,
            font18);
        SdlHardware.ShowHiddenScreen();

        SdlHardware.Pause(2000);
    }
}

