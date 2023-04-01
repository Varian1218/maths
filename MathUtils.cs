namespace Maths
{
    public static class MathUtils
    {
        public static double Lerp(double a, double b, double t)
        {
            return a * (1 - t) + b * t;
        }
    }
}