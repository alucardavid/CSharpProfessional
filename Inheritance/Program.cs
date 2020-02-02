using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle();
            r.Position.X = 33;
            r.Position.Y = 22;
            r.Size.Width = 200;
            r.Size.Heigth = 100;
            r.Draw();
        }
    }
}
