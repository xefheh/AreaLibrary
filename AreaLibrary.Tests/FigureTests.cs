namespace AreaLibrary.Tests
{
    public class CircleTests
    {
        [TestCase(2, 12.5664)]
        [TestCase(0, 0)]
        [TestCase(4, 50.2655)]
        [TestCase(0.4, 0.5027)]
        public void GetCircleArea_WithRadius_DynamicMethod(double radius, double expectedArea)
        {
            Circle circle = new() { Radius = radius };
            Assert.That(circle.GetArea(), Is.EqualTo(expectedArea).Within(0.01));
        }

        [TestCase(2, 12.5664)]
        [TestCase(0, 0)]
        [TestCase(4, 50.2655)]
        [TestCase(0.4, 0.5027)]
        public void GetCircleArea_WithRadius_StaticMethod(double radius, double expectedArea)
        {
            Circle circle = new() { Radius = radius };
            Assert.That(Figure.GetArea(circle), Is.EqualTo(expectedArea).Within(1E-3));
        }
    }

    public class TriangleTests
    {
        [TestCase(1, 1, 1, 0.43301)]
        [TestCase(1, 2, 3, 0)]
        [TestCase(2, 4, 5, 3.79967)]
        [TestCase(5, 4, 5, 9.16515)]
        public void GetTriangleArea_WithSides_DynamicMethod(double aSideLength, 
            double bSideLength, double cSideLength, double expectedArea)
        {
            Triangle triangle = new()
            {
                ASideLength = aSideLength,
                BSideLength = bSideLength,
                CSideLength = cSideLength
            };
            Assert.That(triangle.GetArea(), Is.EqualTo(expectedArea).Within(1E-5));
        }

        [TestCase(1, 1, 1, 0.43301)]
        [TestCase(1, 2, 3, 0)]
        [TestCase(2, 4, 5, 3.79967)]
        [TestCase(5, 4, 5, 9.16515)]
        public void GetTriangleArea_WithSides_StaticMethod(double aSideLength,
            double bSideLength, double cSideLength, double expectedArea)
        {
            Triangle triangle = new()
            {
                ASideLength = aSideLength,
                BSideLength = bSideLength,
                CSideLength = cSideLength
            };
            Assert.That(Figure.GetArea(triangle), Is.EqualTo(expectedArea).Within(1E-5));
        }

        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(6, 8, 10)]
        [TestCase(1, 2, 2.23606)]
        public void TriangleIsRight_DynamicMethod(double aSideLength,
            double bSideLength, double cSideLength)
        {
            Triangle triangle = new()
            {
                ASideLength = aSideLength,
                BSideLength = bSideLength,
                CSideLength = cSideLength
            };
            Assert.That(triangle.IsRight());
        }

        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(6, 8, 10)]
        [TestCase(1, 2, 2.23606)]
        public void TriangleIsRight_StaticMethod(double aSideLength,
            double bSideLength, double cSideLength)
        {
            Triangle triangle = new()
            {
                ASideLength = aSideLength,
                BSideLength = bSideLength,
                CSideLength = cSideLength
            };
            Assert.That(Triangle.IsRight(triangle));
        }
    }
}