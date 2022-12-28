namespace AreaLibrary
{
    public abstract class Figure
    {
        public abstract double GetArea();

        public static double GetArea(Figure figure)
        {
            return figure.GetArea();
        }
    }
}
