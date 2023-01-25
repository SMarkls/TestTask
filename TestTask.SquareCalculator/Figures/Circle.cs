namespace TestTask.SquareCalculator.Figures;

public class Circle : ISquareCalculable
{
    private double radius;

    public double Radius
    {
        get => radius;
        set => 
            radius = value >= 0
            ? value
            : throw new ArgumentException("The value of the side can't be negative", nameof(value));
    }

    public Circle(double radius)
    {
        if (radius >= 0)
            Radius = radius;
        else
            throw new ArgumentException("The value of Radius can't be negative", nameof(Radius));
    }
    public double GetSquare()
    {
        if (Radius >= 0)
            return Math.PI * Radius * Radius;
        throw new ArgumentException("The value of Radius can't be negative", nameof(Radius));
    }
}