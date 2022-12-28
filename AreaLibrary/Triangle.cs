using System;

namespace AreaLibrary
{
    public class Triangle : Figure
    {
        public double ASideLength { get; set; }
        public double BSideLength { get; set; }
        public double CSideLength { get; set; }

        private double HalfMeter => (ASideLength + BSideLength + CSideLength) / 2;

        public override double GetArea() => Math.Sqrt(HalfMeter *
                                                      (HalfMeter - ASideLength) *
                                                      (HalfMeter - BSideLength) *
                                                      (HalfMeter - CSideLength));
        public bool IsRight()
        {
            return Math.Abs(ASideLength * ASideLength + BSideLength * BSideLength - CSideLength * CSideLength) < 1E-4 ||
                   Math.Abs(ASideLength * ASideLength + CSideLength * CSideLength - BSideLength * BSideLength) < 1E-4 ||
                   Math.Abs(BSideLength * BSideLength + CSideLength * CSideLength - ASideLength * ASideLength) < 1E-4;
        }

        public static bool IsRight(Triangle triangle)
        {
            double aSideLength = triangle.ASideLength;
            double bSideLength = triangle.BSideLength;
            double cSideLength = triangle.CSideLength;
            return Math.Abs(aSideLength * aSideLength + bSideLength * bSideLength - cSideLength * cSideLength) < 1E-4 ||
                   Math.Abs(aSideLength * aSideLength + cSideLength * cSideLength - bSideLength * bSideLength) < 1E-4 ||
                   Math.Abs(bSideLength * bSideLength + cSideLength * cSideLength - aSideLength * aSideLength) < 1E-4;
        }
    }
}
