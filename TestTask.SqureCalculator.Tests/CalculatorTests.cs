using TestTask.SquareCalculator;
using TestTask.SquareCalculator.Figures;

namespace TestTask.SqureCalculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Square_With_Three_Sides()
    {
        double a = 5;
        double b = 4;
        double c = 3;

        var actual = Calculator.CalculateSquare(a, b, c);
        var expected = 6;
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Square_With_Radius()
    {
        double radius = 3;

        var actual = Calculator.CalculateSquare(radius);
        var expected = Math.PI * 9;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Throw_Exception_Due_Negative_Parameter_Overload_With_Three_Sides()
    {
        double a = -1;
        double b = 1;
        double c = 1;

        Action testCode = () => Calculator.CalculateSquare(a, b, c);

        Assert.Throws<ArgumentException>(nameof(a), testCode);
    }

    [Fact]
    public void Throw_Exception_Due_Negative_Parameter_Overload_With_Radius()
    {
        double radius = -1;

        Action testCode = () => Calculator.CalculateSquare(radius);

        Assert.Throws<ArgumentException>(nameof(radius), testCode);
    }

    [Fact]
    public void Square_Of_Triangle()
    {
        Triangle triangle = new Triangle(5, 4, 3);

        var actual = Calculator.CalculateSquare(triangle);
        var expected = 6;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Square_Of_Circle()
    {
        Circle circle = new Circle(5);

        var actual = Calculator.CalculateSquare(circle);
        var expected = Math.PI * 25;

        Assert.Equal(expected, actual);
    }
}