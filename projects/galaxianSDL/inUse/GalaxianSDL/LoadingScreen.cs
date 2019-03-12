// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023, 12-Mar-19   Nacho: Position adapted to 1280x720 (16:9, HD)
// 012, 21-Feb-19   Enrique, Gonzalo: Login screen for 3 seconds
// 009, 21-Feb-19   Nacho: Empty skeleton

class LoadingScreen
{
    protected Image loginImage;

    public LoadingScreen()
    {
        loginImage = new Image("data/galaxian_logo.png");
    }

    public void Run()
    {
        SdlHardware.ClearScreen();
        SdlHardware.DrawHiddenImage(loginImage, 340, 300);
        SdlHardware.ShowHiddenScreen();

        SdlHardware.Pause(3000);
    }
}


