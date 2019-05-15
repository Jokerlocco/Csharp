// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 028, 06-May-19   Nacho: Moving credits. Size changed from 18 to 24
// 017, 21-Feb-19   Javier y Daniel: Names of the dev team
// 009, 21-Feb-19   Nacho: Empty skeleton

class CreditsScreen
{
    const short START_Y_POSITION = 225;

    private Font font24;
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
        font24 = new Font("data/Joystix.ttf", 24);

        namesX = 450;
        namesY = START_Y_POSITION;

        red = 255;
        green = 255;
        blue = 0;
    }

    public void Run()
    {
        int displacement = 0;
        int waveSize = 240;
        float degrees = 0;
        do
        {
            SdlHardware.ClearScreen();
            SdlHardware.WriteHiddenText(
                "(Partial) Remake by students of 1 DAM, "
                    +"I.E.S. San Vicente, 2018/19",
                50, 130,
                255, 255, 255,
                font24);
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

                displacement = (int) (waveSize
                    * System.Math.Sin(degrees * 3.14f / 360.0));
                degrees += 0.1f;
                SdlHardware.WriteHiddenText(
                    names[i], 
                    (short) (namesX+displacement), namesY, 
                    red, green, blue, font24);
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
                font24);
            SdlHardware.ShowHiddenScreen();

            SdlHardware.Pause(20); // 50 fps
            namesX = 450;
        }
        while (!SdlHardware.KeyPressed(SdlHardware.KEY_R));
    }
}
