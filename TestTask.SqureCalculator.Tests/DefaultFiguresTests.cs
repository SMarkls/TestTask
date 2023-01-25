using TestTask.SquareCalculator.Figures;

namespace TestTask.SqureCalculator.Tests;

public class DefaultFiguresTests
{
    [Fact]
    public void Throw_Exception_Due_Negative_Side()
    {
        Action action = () =>
        {
            Triangle triangle = new Triangle(1, 1, -1);
        };

        Assert.Throws<ArgumentException>("c", action);
    }

    [Fact]
    public void Throw_Exception_Due_Negative_Raduis()
    {
        Action action = () =>
        {
            Circle circle = new Circle(-1);
        };

        Assert.Throws<ArgumentException>("Radius", action);
    }

    [Fact]
    public void Throw_Exception_Due_Negative_Side_After_Trying_To_Edit()
    {
        Triangle triangle = new Triangle(1, 1, 1);

        Action action = () => triangle.A = -5;

        Assert.Throws<ArgumentException>("value", action);
    }

    [Fact]
    public void Throw_Exception_Due_Negative_Radius_After_Trying_To_Edit()
    {
        Circle circle = new Circle(5);

        Action action = () => circle.Radius = -5;

        Assert.Throws<ArgumentException>("value", action);
    }
}