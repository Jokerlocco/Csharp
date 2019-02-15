# sv2018-programming

## Nodes Of Yesod 013

### Scroll

A simple way to create a scroll, if we have enough memory and we are using a 
graphics library which supports "clipping" (we can draw outside of the
screen coordinates and it does not blow our system, just nothing gets drawn)
is to draw the whole world in changing corrdinates.

Our class SdlHardware suuports scrolling the whole world with the following 
functions:

```
void ScrollVertically(short yDespl)
void ScrollHorizontally(short xDespl)
void ScrollTo(short newStartX, short newStartY)
void ResetScroll()
```

This game (Nodes of Yesod) does not really use any scroll, but we can include
it in the help screen. The basic idea is:

```
do
{ 
    // Draw items on screen
    SdlHardware.ClearScreen();
    SdlHardware.DrawHiddenImage(background, 0, 0);
    // ...

    // Get user input
    if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
    {
        SdlHardware.ScrollHorizontally((short) (-speed));
    }
    if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
    {
        SdlHardware.ScrollHorizontally(speed);
    }

    // And pause (25 fps)
    SdlHardware.Pause(40);
}
while (!SdlHardware.KeyPressed(SdlHardware.KEY_R));
SdlHardware.ResetScroll();
```

We can also include the player, to make it more fun, so the whole source
for WelcomeScreen would now be like this:

```
class HelpScreen
{
    public void Run()
    {
        string[] text =
        {
            "Use arrow keys to move right or left",
            "Use spacebar to jump",
            "Arrows + spacebar to jump sidewards",
            "Beware of the moving enemies",
            "Press Q to quit the game",
            " ",
            "Press R to Return"
        };

        Image background = new Image("data/help.png");
        Font font18 = new Font("data/Joystix.ttf", 18);

        Player player = new Player();
        player.MoveTo(510, 558);
        short playerSpeed = 4;

        byte grey = 200;
        short x = 300;
        short y = 250;
        short spacing = 40;

        do
        { 
            // Draw items on screen
            SdlHardware.ClearScreen();
            SdlHardware.DrawHiddenImage(background, 0, 0);
            

            grey = 200;
            y = 250;
            for (int i = 0; i < text.Length; i++)
            {
                SdlHardware.WriteHiddenText(text[i],
                    x, y,
                    grey, grey, grey,
                    font18);
                grey -= 20;
                y += spacing;
            }
            player.DrawOnHiddenScreen();
            SdlHardware.ShowHiddenScreen();

            // Animate the player (it is must fall or jump)
            player.Move();

            // Get user input to move the player as desired

            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT)
                && (player.GetX() < 700))
            {
                player.ChangeDirection(Sprite.RIGHT);
                SdlHardware.ScrollHorizontally((short) (-playerSpeed));
                player.MoveTo(player.GetX() + playerSpeed, player.GetY());
                player.NextFrame();
            }
            if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT)
                && (player.GetX() > 300))
            {
                player.ChangeDirection(Sprite.LEFT);
                SdlHardware.ScrollHorizontally(playerSpeed);
                player.MoveTo(player.GetX() - playerSpeed, player.GetY());
                player.NextFrame();
            }

            // And pause (25 fps)
            SdlHardware.Pause(40);
        }
        while (!SdlHardware.KeyPressed(SdlHardware.KEY_R));
        SdlHardware.ResetScroll();
    }
}

```
