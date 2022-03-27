using System.Drawing;

namespace SpaceButtleHomeTask2.Interfaces
{
    public interface IAdapter<T>
    {
        Point Execute(UObject _uObject, T value);
    }
}
