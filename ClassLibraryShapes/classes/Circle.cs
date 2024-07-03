using ClassLibraryShapes.interfaces;
using System.Numerics;


namespace ClassLibraryShapes.Classes;

public class Circle : IShape<double> 
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
