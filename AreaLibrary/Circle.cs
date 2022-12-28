using System;

namespace AreaLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public override double GetArea() => Math.PI * Radius * Radius;
    }
}
