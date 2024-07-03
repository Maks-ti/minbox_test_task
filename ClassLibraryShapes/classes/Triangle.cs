using ClassLibraryShapes.interfaces;
using System.Numerics;

namespace ClassLibraryShapes.Classes;

public class Triangle<T> : IShape<T> where T : INumber<T>
{
    private readonly double _epsilon = 1e-10; // точность расчётов
    public T SideA { get; }
    public T SideB { get; }
    public T SideC { get; }

    public Triangle(T sideA, T sideB, T sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        if (!IsValidTriangle())
        {
            throw new ArgumentException("The given sides do not form a valid triangle.");
        }
    }

    public T GetArea()
    {
        T semiPerimeter = (SideA + SideB + SideC) / T.CreateChecked(2);
        double semiPerimeterDouble = double.CreateChecked(semiPerimeter);
        double sideADouble = double.CreateChecked(SideA);
        double sideBDouble = double.CreateChecked(SideB);
        double sideCDouble = double.CreateChecked(SideC);

        // формула герона
        double areaDouble = Math.Sqrt(semiPerimeterDouble * (semiPerimeterDouble - sideADouble) * (semiPerimeterDouble - sideBDouble) * (semiPerimeterDouble - sideCDouble));
        return T.CreateChecked(areaDouble);
    }

    public bool IsRightTriangle()
    {
        T[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);

        T squareC = sides[2] * sides[2];
        T squareSumAB = sides[0] * sides[0] + sides[1] * sides[1];

        return T.Abs(squareC - squareSumAB) < T.CreateChecked(_epsilon);
    }

    private bool IsValidTriangle()
    {
        return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
    }
}
