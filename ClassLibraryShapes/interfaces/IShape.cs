
using System.Numerics; // начиная с .net 7 у нас появляется интерфейс INumber

namespace ClassLibraryShapes.interfaces;

public interface IShape<T> where T : INumber<T>
{
    T GetArea();
}
