using System.Drawing;

namespace SpaceButtleHomeTask2.Interfaces
{
    public interface IMovable
    {
        Point MoveLinearMotion(UObject uObject, Point position);
    }
}
