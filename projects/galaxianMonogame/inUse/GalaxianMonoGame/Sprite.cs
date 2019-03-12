/**
 * Sprite.cs - A basic graphic element to inherit from
 * 
 * Changes:
 * // 023m,12-Mar-19   Nacho: Adapted to Monogame
 * 0.20, 26-02-2019: Added "SetGameUpdatesPerFrame" to adjust animation speed.
 *    Draw is virtual.
 * 0.01, 24-jul-2013: Initial version, based on SdlMuncher 0.12
 */

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

class Sprite
{
    protected int x, y;
    protected int startX, startY;
    protected int width, height;
    protected int xSpeed, ySpeed;
    protected bool visible;
    protected Texture2D image;
    protected Texture2D[][] sequence;
    protected bool containsSequence;
    protected int gameUpdatesPerFrame;  // To change the image atfer several updates
    protected int currentFrame;
    protected int currentFrameTick;

    protected byte numDirections = 11;
    protected byte currentDirection;
    public const byte RIGHT = 0;
    public const byte LEFT = 1;
    public const byte DOWN = 2;
    public const byte UP = 3;
    public const byte DOWNRIGHT = 4;
    public const byte DOWNLEFT = 5;
    public const byte UPRIGHT = 6;
    public const byte UPLEFT = 7;
    public const byte APPEARING = 8;
    public const byte DISAPPEARING = 9;
    public const byte JUMPING = 9;

    public Sprite()
    {
        startX = -1;
        startY = -1;
        width = 32;
        height = 32;
        visible = true;
        sequence = new Texture2D[numDirections][];
        currentDirection = RIGHT;
        gameUpdatesPerFrame = 10;
    }

    public Sprite(string imageName, ContentManager c)
        : this()
    {
        LoadImage(imageName, c);
    }

    public Sprite(string[] imageNames, ContentManager c)
        : this()
    {
        LoadSequence(imageNames, c);
    }

    public void LoadImage(string name, ContentManager content)
    {
        image = content.Load<Texture2D>(name);

        containsSequence = false;
    }

    public void LoadSequence(byte direction, string[] names, ContentManager content)
    {
        int amountOfFrames = names.Length;
        sequence[direction] = new Texture2D[amountOfFrames];
        for (int i = 0; i < amountOfFrames; i++)
            sequence[direction][i] = content.Load<Texture2D>(names[i]);
        containsSequence = true;
        currentFrame = 0;
    }

    public void LoadSequence(string[] names, ContentManager content)
    {
        LoadSequence(RIGHT, names, content);
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }

    public int GetWidth()
    {
        return width;
    }

    public int GetHeight()
    {
        return height;
    }

    public int GetSpeedX()
    {
        return xSpeed;
    }

    public int GetSpeedY()
    {
        return ySpeed;
    }

    public bool IsVisible()
    {
        return visible;
    }

    public void MoveTo(int newX, int newY)
    {
        x = newX;
        y = newY;
        if (startX == -1)
        {
            startX = x;
            startY = y;
        }
    }

    public void SetSpeed(int newXSpeed, int newYSpeed)
    {
        xSpeed = newXSpeed;
        ySpeed = newYSpeed;
    }

    public void Show()
    {
        visible = true;
    }

    public void Hide()
    {
        visible = false;
    }

    public virtual void Move()
    {
        // To be redefined in subclasses
    }

    public virtual void DrawOnHiddenScreen(SpriteBatch sprites)
    {
        if (!visible)
            return;

        if (containsSequence)
            sprites.Draw(sequence[currentDirection][currentFrame], 
                new Vector2(x, y), Color.White);
        else
            sprites.Draw(image, new Vector2(x, y), Color.White);
    }

    public void NextFrame()
    {
        currentFrameTick++;
        if (currentFrameTick < gameUpdatesPerFrame)
            return;
        currentFrameTick = 0;

        currentFrame++;
        if (currentFrame >= sequence[currentDirection].Length)
            currentFrame = 0;
    }

    public void ChangeDirection(byte newDirection)
    {
        if (!containsSequence) return;
        if (currentDirection != newDirection)
        {
            currentDirection = newDirection;
            currentFrame = 0;
        }

    }

    public bool CollisionsWith(Sprite otherSprite)
    {
        return (visible && otherSprite.IsVisible() &&
            CollisionsWith(otherSprite.GetX(),
                otherSprite.GetY(),
                otherSprite.GetX() + otherSprite.GetWidth(),
                otherSprite.GetY() + otherSprite.GetHeight()));
    }

    public bool CollisionsWith(int xStart, int yStart, int xEnd, int yEnd)
    {
        if (visible &&
                (x < xEnd) &&
                (x + width > xStart) &&
                (y < yEnd) &&
                (y + height > yStart)
                )
            return true;
        return false;
    }

    public void Restart()
    {
        x = startX;
        y = startY;
    }

    /// Sets number of calls to "NextFrame" which really change the visible image
    public void SetGameUpdatesPerFrame(int updates)
    {
        gameUpdatesPerFrame = updates;
    }
}
