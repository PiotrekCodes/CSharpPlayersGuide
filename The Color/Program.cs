var color1 = new Color(123, 20, 69);
var color2 = new Color(10, 169, 234);

Console.WriteLine($"Red: {color1.R}, Green: {color1.G}, Blue: {color1.B}");
Console.WriteLine($"Red: {color2.R}, Green: {color2.G}, Blue: {color2.B}");


public class Color
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }

    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    private static Color White = new Color(255, 255, 255);
    private static Color Black = new Color(0, 0, 0);
    private static Color Red = new Color(255, 0, 0);
    private static Color Orange = new Color(255,165, 0);
    private static Color Yellow = new Color(255, 255, 0);
    private static Color Green = new Color(0, 128, 0);
    private static Color Blue = new Color(0, 0, 255);
    private static Color Purple = new Color(128, 0, 128);

}