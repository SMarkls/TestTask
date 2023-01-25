using TestTask.SquareCalculator.Figures;

namespace TestTask.SquareCalculator;

public static class TriangleUtils
{
    /// <summary>
    /// Determines if the triangle right.
    /// </summary>
    /// <param name="triangle">Triangle to determine.</param>
    /// <returns>True if it right.</returns>
    public static bool IsTriangleRight(Triangle triangle)
    {
        List<double> sides = new List<double> { triangle.A, triangle.B, triangle.C };

        
        double max = sides.Max();
        double min = sides.Min();
        sides.Remove(min);
        sides.Remove(max);
        double mid = sides.First();

        if (max * max == min * min + mid * mid)
            return true;
        return false;
    }
    
    /// <summary>
    /// Determines if the triangle with given sides right.
    /// </summary>
    /// <param name="a">The first side of the triangle.</param>
    /// <param name="b">The second side of the triangle.</param>
    /// <param name="c">The third side of the triangle.</param>
    /// <returns>True if the triangle right.</returns>
    /// <exception cref="ArgumentException">Throws if at least one of the sides is negative.</exception>
    public static bool IsTriangleRight(double a, double b, double c)
    {
        Triangle triangle = new Triangle(a, b, c);
        return IsTriangleRight(triangle);
    }
}