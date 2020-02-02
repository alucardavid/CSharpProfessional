using System;
namespace Inheritance
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() => $"X: {X}, Y: {Y}";
    }

    public class Size
    {
        public int Width { get; set; }
        public int Heigth { get; set; }
        public override string ToString() => $"Width: {Width}, Height: {Heigth}";
    }


    public class Shape
    {
        public Position Position { get; } = new Position();
        public Size Size { get; } = new Size();

        public virtual void Draw() => Console.WriteLine($"Shape with {Position} and {Size}");
    }
}
