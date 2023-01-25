using TestTask.SquareCalculator;
using TestTask.SquareCalculator.Figures;

namespace TestTask.SqureCalculator.Tests;

public class TriangleUtilsTests
{
    [Fact]
    public void Should_Return_That_Triangle_Is_Right()
    {
        double a = 5;
        double b = 4;
        double c = 3;

        Triangle triangle = new Triangle(a, b, c);

        bool actual = TriangleUtils.IsTriangleRight(triangle);

        Assert.True(actual);
    }

    [Fact]
    public void Should_Return_That_Triangle_Is_Right_By_Three_Sides()
    {
        double a = 5;
        double b = 4;
        double c = 3;

        bool actual = TriangleUtils.IsTriangleRight(a, b, c);
        
        Assert.True(actual);
    }

    [Fact]
    public void Should_Return_That_Triangle_Is_Not_Right()
    {
        double a = 1;
        double b = 1;
        double c = 1;

        Triangle triangle = new Triangle(a, b, c);

        bool actual = TriangleUtils.IsTriangleRight(triangle);
        
        Assert.False(actual);
    }

    [Fact]
    public void Should_Return_That_Triangle_Is_Not_Right_By_Three_Sides()
    {
        double a = 1;
        double b = 1;
        double c = 1;

        bool actual = TriangleUtils.IsTriangleRight(a, b, c);
        
        Assert.False(actual);
    }
}