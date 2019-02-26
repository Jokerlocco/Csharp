// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 022, 26-Feb-19   Nacho: Info is displayed, 
//                    Welcome is not called, but returned to
// 019, 21-Feb-19   Manuel Lago, José V. Antón: 
//                    Created configuration menu to change configuration 
//                    parameters like sprites resolution

using System.Collections.Generic;

class ConfigScreen
{
    Font font18;
    static bool[] configuration = { false };
    int index;

    public static bool GetOption(int index)
    {
        return configuration[index];
    }

    public ConfigScreen()
    {
        font18 = new Font("data/Joystix.ttf", 18);
        index = 0;
    }

    public void Run()
    {
        // Display until the user presses ESC
        while (SdlHardware.KeyPressed(SdlHardware.KEY_ESC) == false)
        {
            SdlHardware.ClearScreen();
            SdlHardware.WriteHiddenText("Change option with up and down arrows, change selected option with space",
                40, 110,
                0xCC, 0xCC, 0xCC,
                font18);

            SdlHardware.WriteHiddenText("High Resolution Mode: " + (configuration[0] ? "YES" : "NO"),
                    40, 310,
                    (index == 0 ? (byte)0xCC : (byte)0xFF), 0xCC, 0xCC,
                    font18);
            SdlHardware.ShowHiddenScreen();

            SdlHardware.Pause(50); // So that we do not use a 100% CPU

            if (SdlHardware.KeyPressed(SdlHardware.KEY_DOWN))
            {
                if (index < configuration.Length)
                {
                    index++;
                }
                else
                {
                    index = 0;
                }

            }

            if (SdlHardware.KeyPressed(SdlHardware.KEY_UP))
            {
                if (index > 0)
                {
                    index--;
                }
                else
                {
                    index = configuration.Length - 1;
                }
            }

            if (SdlHardware.KeyPressed(SdlHardware.KEY_SPC))
            {
                configuration[index] = !configuration[index];
            }

            if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
            {
                return;
            }
        }
    }
}

