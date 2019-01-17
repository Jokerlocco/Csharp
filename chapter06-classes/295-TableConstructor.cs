// Table + Leg + TableTest (2)

// -------------------------------------------------------------

class Table
{
    protected int width, length;
    protected string color;
    protected Leg myLeg;
    
    public Table(int w, int l, string col)
    {
        width = w;
        length = l;
        color = col;
    }
    
    public int GetWidth() { return width; }
    public int GetLength() { return length; }
    public string GetColor() { return color; }
    public Leg GetLeg() { return myLeg; }
    
    public void SetWidth(int w) { width = w; }
    public void SetLength(int l) { length = l; }
    public void SetColor(string c) { color = c; }
    public void SetLeg(Leg l) { myLeg = l; }
}


// -------------------------------------------------------------

class Leg
{
    protected int height;
    protected string color;
    
    public Leg(int h, string col)
    {
        height = h;
        color = col;
    }

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
        Table t = new Table(80, 120, "oak");
        Leg l = new Leg(78, "silver");
        t.SetLeg(l);
    }
}
