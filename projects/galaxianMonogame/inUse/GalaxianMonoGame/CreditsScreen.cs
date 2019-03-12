// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Adapted to Monogame
// 017, 21-Feb-19   Javier y Daniel: Names of the dev team
// 009, 21-Feb-19   Nacho: Empty skeleton

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class CreditsScreen
{
    GraphicsDeviceManager graphics;
    ContentManager content;

    private SpriteFont font;
    private ScreensManager manager;

    const short START_Y_POSITION = 225;

    private Font font18;
    private string[] names = { "Pablo", "Ivan", "Cristina", "Maria", "Adrian", "Sergio", "Diego", "Miguel",
        "Kevin", "Jaime", "Araceli", "Ruth", "Saul", "Jorge", "Enrique", "Gonzalo", "Miguel", "Jose",
        "Manuel", "Javier", "Daniel", "Nacho"};

    private short namesX;
    private short namesY;

    private byte red;
    private byte green;
    private byte blue;

    public CreditsScreen(ScreensManager manager)
    {
        this.manager = manager;

        namesX = 375;
        namesY = START_Y_POSITION;

        red = 255;
        green = 255;
        blue = 0;
    }

    public void LoadContent(ContentManager Content)
    {
        font = Content.Load<SpriteFont>("Joystix18");
    }

    public void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.R))
        {
            manager.currentMode = ScreensManager.MODE.WELCOME;
        }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        namesX = 375;
        namesY = START_Y_POSITION;
        spriteBatch.DrawString(font, "(Partial) Remake by 1 DAM", new Vector2(340, 130), Color.White);

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

            spriteBatch.DrawString(font, names[i], new Vector2(namesX, namesY), new Color(red, green, blue));
            namesY += 30;

            if (i % 11 == 10)
            {
                namesY = START_Y_POSITION;
                namesX += 200;
            }
        }
        spriteBatch.DrawString(font, "R to Return", new Vector2(440, 620), Color.Red);
    }
}