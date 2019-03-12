/**
 * Font.cs - To hide SDL TTF font handling
 * 
 * Changes:
// 023m,12-Mar-19   Nacho: Adapted to Monogame
 * 0.01, 24-jul-2013: Initial version, based on SdlMuncher 0.02
 */

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

class Font
{
    SpriteFont myfont;
    public Font(string fileName, ContentManager c)
    {
        myfont = c.Load<SpriteFont>(fileName);
    }

    public void EscribirTextoOculta(string texto, int x, int y, Color miColor, SpriteBatch sprites)
    {
        if ((texto == null) || (texto == ""))
            return;
        sprites.DrawString(myfont, texto, new Vector2(x, y), miColor);
    }

    public void EscribirTextoOculta(string texto, int x, int y, int r, int g, int b, SpriteBatch sprites)
    {
        sprites.DrawString(myfont, texto, new Vector2(x, y), new Color(r, g, b));
    }
    /*
    private IntPtr internalPointer;

    public Font(string fileName, short sizePoints)
    {
        Load(fileName, sizePoints);
    }

    public void Load(string fileName, short sizePoints)
    {
        internalPointer = SdlTtf.TTF_OpenFont(fileName, sizePoints);
        if (internalPointer == IntPtr.Zero)
            SdlHardware.FatalError("Font not found: " + fileName);
    }

    public IntPtr GetPointer()
    {
        return internalPointer;
    }
    */
}
