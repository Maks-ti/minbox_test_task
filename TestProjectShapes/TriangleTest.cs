using Xunit;
using ClassLibraryShapes.Classes;

namespace TestProjectShapes;

public class TriangleTests
{
    [Fact]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle<double>(3.0, 4.0, 5.0);
        double expectedArea = 6.0;
        Assert.Equal(expectedArea, triangle.GetArea(), precision: 5);
    }

    [Fact]
    public void IsRightTriangleTest()
    {
        var triangle = new Triangle<double>(3.0, 4.0, 5.0);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void InvalidTriangleTest()
    {
        Assert.Throws<ArgumentException>(() => new Triangle<double>(1.0, 1.0, 3.0));
    }
}
