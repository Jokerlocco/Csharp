// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Adapted to Monogame
// 022, 26-Feb-19   Nacho: Info is displayed, 
//                    Welcome is not called, but returned to
// 019, 21-Feb-19   Manuel Lago, José V. Antón: 
//                    Created configuration menu to change configuration 
//                    parameters like sprites resolution

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System.Collections.Generic;

class ConfigScreen
{
    GraphicsDeviceManager graphics;
    ContentManager content;

    private SpriteFont font;
    private ScreensManager manager;
    static bool[] configuration = { false };
    int index;

    public static bool GetOption(int index)
    {
        return configuration[index];
    }

    public ConfigScreen(ScreensManager manager)
    {
        this.manager = manager;
    }

    public void LoadContent(ContentManager Content)
    {
        font = Content.Load<SpriteFont>("Joystix18");
    }

    public void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Up))
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

        if (Keyboard.GetState().IsKeyDown(Keys.Down))
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

        if (Keyboard.GetState().IsKeyDown(Keys.Space))
        {
            configuration[index] = !configuration[index];
        }

        if (Keyboard.GetState().IsKeyDown(Keys.R))
        {
            manager.currentMode = ScreensManager.MODE.WELCOME;
        }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font,
            "Change option with up and down arrows, change selected option with space", 
            new Vector2(40, 110), Color.Gray);
        spriteBatch.DrawString(font, "High Resolution Mode: " + (configuration[0] ? "YES" : "NO"), 
                new Vector2(40, 310), new Color (index == 0 ? (byte)0xCC : (byte)0xFF, 0xCC, 0xCC));
    }
}
