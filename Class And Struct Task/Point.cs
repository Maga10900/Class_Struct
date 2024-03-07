namespace Class_And_Struct_Task;

public class Point
{
    public int x { get; set; }
    public int y { get; set; }
    public Point()
    {
        this.x = 0;
        this.y = 0;
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Point(Point other)
    {
        this.x = other.x;
        this.y = other.y;
    }
    public void increment()
    {
        this.x++;
        this.y++;
    }
    public void decrement()
    {
        this.x--;
        this.y--;
    }
    public void Show()
    {
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}
