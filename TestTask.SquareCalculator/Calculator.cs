using TestTask.SquareCalculator.Figures;

namespace TestTask.SquareCalculator;

public class Calculator
{
    /// <summary>
    /// Calculates square of triangle by lengths of three sides of triangle.
    /// </summary>
    /// <param name="a">Length of the first side of the triangle.</param>
    /// <param name="b">Length of the second side of the triangle.</param>
    /// <param name="c">Length of the third side of the triangle.</param>
    /// <returns>Square of the triangle</returns>
    /// <exception cref="ArgumentException">Throws if the at least one of sides is negative.</exception>
    public static double CalculateSquare(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
            throw new ArgumentException("The value of side can't be negative.",
                a < 0 ? nameof(a) : b < 0 ? nameof(b) : nameof(c));
        double p = (a + b + c) / 2; // half-perimeter
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Heron's formula
    }
    
    
    /// <summary>
    /// Calculates square of circle by length of radius.
    /// </summary>
    /// <param name="radius">Length of the radius of circle.</param>
    /// <returns>Square of the circle.</returns>
    /// <exception cref="ArgumentException">Throws if the radius is negative.</exception>
    public static double CalculateSquare(double radius)
    {
        if (radius >= 0)
            return Math.PI * radius * radius;
        throw new ArgumentException("The value of radius can't be negative", nameof(radius));
    }
    
    
    /// <summary>
    /// Calculates square of the figure
    /// </summary>
    /// <param name="squareCalculable">The object that implements <see cref="ISquareCalculable"/> interface</param>
    /// <returns>Square of the figure</returns>
    public static double CalculateSquare(ISquareCalculable squareCalculable) => squareCalculable.GetSquare();
}