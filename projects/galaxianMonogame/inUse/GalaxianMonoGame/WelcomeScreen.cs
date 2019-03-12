// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Adapted to Monogame
// 022, 26-Feb-19   Nacho: Options are constants, used in galaxian.cs
// 018, 21-Feb-19   Enrique, Gonzalo: Menu for the game
// 009, 21-Feb-19   Nacho: Access to LoadingScreen, CreditsScreen and HelpScr
// 008, 04-Ene-19   Nacho: Extracted from class GalaxianSDL
// 007, 06-Dic-18   S. Ruescas: Created Welcome Screen

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class WelcomeScreen
{
    GraphicsDeviceManager graphics;
    ContentManager content;

    private SpriteFont font;
    private ScreensManager manager;

    public WelcomeScreen(ScreensManager manager)
    {
        this.manager = manager;
    }

    public void LoadContent(ContentManager Content)
    {
        font = Content.Load<SpriteFont>("Joystix24");
    }

    public void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.D1))
        {
            manager.currentMode = ScreensManager.MODE.GAME;
        }
        else if (Keyboard.GetState().IsKeyDown(Keys.D2))
        {
            manager.currentMode = ScreensManager.MODE.HELP;
        }
        else if (Keyboard.GetState().IsKeyDown(Keys.D3))
        {
            manager.currentMode = ScreensManager.MODE.CREDITS;
        }
        else if (Keyboard.GetState().IsKeyDown(Keys.K))
        {
            manager.currentMode = ScreensManager.MODE.CONFIG;
        }
        else if (Keyboard.GetState().IsKeyDown(Keys.Q))
        {
            manager.Exit();
        }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font, "1.- Play", new Vector2(380, 240), Color.White);
        spriteBatch.DrawString(font, "2.- Help", new Vector2(380, 280), Color.Silver);
        spriteBatch.DrawString(font, "3.- Credits", new Vector2(380, 320), Color.DarkGray);
        spriteBatch.DrawString(font, "K. Config", new Vector2(380, 360), Color.Gray);
        spriteBatch.DrawString(font, "Q. Quit", new Vector2(380, 400), Color.DimGray);
    }
}
