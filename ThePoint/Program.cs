var point1 = new Point(2, 3);
var point2 = new Point(-4, 0);

Console.WriteLine($"({point1.X} {point1.Y})");
Console.WriteLine($"({point2.X} {point2.Y})");
class Point
{
   public float X { get; }
   public float Y { get; }

   public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
    
    public Point() : this(0,0)  {}
}