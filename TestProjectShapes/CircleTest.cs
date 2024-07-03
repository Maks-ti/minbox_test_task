using ClassLibraryShapes.Classes;
using Xunit;

namespace TestProjectShapes;

public class CircleTests
{
    [Fact]
    public void CircleAreaTest_Int()
    {
        var circle = new Circle(5);
        double expectedArea = Math.PI * 25;
        Assert.Equal(expectedArea, (double)circle.GetArea(), precision: 3);
    }

    [Fact]
    public void CircleAreaTest_Double()
    {
        var circle = new Circle(5.5);
        double expectedArea = Math.PI * 5.5 * 5.5;
        Assert.Equal(expectedArea, circle.GetArea(), precision: 5);
    }
}