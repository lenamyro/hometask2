using System.Drawing;

namespace SpaceButtleHomeTask2.Interfaces
{
    public interface IAdapter
    {
        Point Execute<TDirection>(Point oldValue, Direction<TDirection> direction);
    }
}
