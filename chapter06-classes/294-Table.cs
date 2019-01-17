// Table + Leg + TableTest 

// -------------------------------------------------------------

class Table
{
    protected int width, length;
    protected string color;
    protected Leg myLeg;
    
    public int GetWidth() { return width; }
    public int GetLength() { return length; }
    public string GetColor() { return color; }
    
    public void SetWidth(int w) { width = w; }
    public void SetLength(int l) { length = l; }
    public void SetColor(string c) { color = c; }
}


// -------------------------------------------------------------

class Leg
{
    protected int height;
    protected string color;

    public int GetHeight() { return height; }
    public string GetColor() { return color; }
    
    public void SetHeight(int h) { height = h; }
    public void SetColor(string c) { color = c; }
}

// -------------------------------------------------------------


class TableTest
{
    static void Main(string[] args)
    {
        Table t = new Table();
    }
}
