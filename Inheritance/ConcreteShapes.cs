using System;
namespace Inheritance
{
    public class Rectangle : Shape
    {

        public override void Draw() => Console.WriteLine($"Rectangle with {Position} and {Size}");

    }
}
