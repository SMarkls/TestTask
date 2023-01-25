namespace TestTask.SquareCalculator.Figures;

public class Triangle : ISquareCalculable
{
    private double a;
    private double b;
    private double c;

    /// <summary>
    /// Length of the first side.
    /// </summary>
    public double A
    {
        get => a;
        set => 
            a = value >= 0
            ? value
            : throw new ArgumentException("The value of the side can't be negative", nameof(value));
    }

    /// <summary>
    /// Length of the second side.
    /// </summary>
    public double B
    {
        get => b;
        set => 
            b = value >= 0
            ? value
            : throw new ArgumentException("The value of the side can't be negative", nameof(value));
    }

    /// <summary>
    /// Length of the third side.
    /// </summary>
    public double C
    {
        get => c;
        set => 
            c = value >= 0
            ? value
            : throw new ArgumentException("The value of the side can't be negative", nameof(value));
    }

    public Triangle(double a, double b, double c)
    {
        if (a >= 0)
            A = a;
        else throw new ArgumentException("The value of the side can't be negative", nameof(a));
        if (b >= 0)
            B = b;
        else throw new ArgumentException("The value of the side can't be negative", nameof(b));
        if (c >= 0)
            C = c;
        else throw new ArgumentException("The value of the side can't be negative", nameof(c));
    }
    public double GetSquare()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}