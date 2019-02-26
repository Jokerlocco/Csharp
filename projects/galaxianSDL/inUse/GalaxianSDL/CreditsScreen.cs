// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 017, 21-Feb-19   Javier y Daniel: Names of the dev team
// 009, 21-Feb-19   Nacho: Empty skeleton

class CreditsScreen
{
    const short START_Y_POSITION = 225;

    private Font font18;
    private string[] names = { "Pablo", "Iván", "Cristi", "María", "Adrián", "Sergio", "Diego", "Miguel",
        "Kevin", "Jaime", "Araceli", "Ruth", "Saúl", "Jorge", "Enrique", "Gonzalo", "Miguel", "José",
        "Manuel", "Javier", "Daniel", "Nacho"};

    private short namesX;
    private short namesY;

    private byte red;
    private byte green;
    private byte blue;

    public CreditsScreen()
    {
        font18 = new Font("data/Joystix.ttf", 18);

        namesX = 375;
        namesY = START_Y_POSITION;

        red = 255;
        green = 255;
        blue = 0;
    }

    public void Run()
    {
        SdlHardware.ClearScreen();
        SdlHardware.WriteHiddenText("(Partial) Remake by 1ºDAM",
            340, 130,
            255, 255, 255,
            font18);
        for (int i = 0; i < names.Length; i++)
        {
            if (i % 1 == 0)
            {
                red = 0;
                green = 190;
                blue = 255;
            }

            if (i % 2 == 1)
            {
                red = 0;
                green = 0;
                blue = 255;
            }

            if (i % 3 == 2)
            {
                red = 255;
                green = 0;
                blue = 255;
            }

            SdlHardware.WriteHiddenText(names[i], namesX, namesY, red, green, blue, font18);
            namesY += 30;

            if (i % 11 == 10)
            {
                namesY = START_Y_POSITION;
                namesX += 200;
            }
        }
        SdlHardware.WriteHiddenText("R to Return",
            440, 620,
            255, 0, 0,
            font18);
        SdlHardware.ShowHiddenScreen();

        do
        {
            SdlHardware.Pause(100); // To avoid using 100% CPU
        }
        while (!SdlHardware.KeyPressed(SdlHardware.KEY_R));
    }
}
