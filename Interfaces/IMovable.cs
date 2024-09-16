using System.Drawing;

namespace SpaceButtleHomeTask2.Interfaces
{
    public interface IMovable
    {
        Point MoveLinearMotion(Point oldPosition, Point position);
    }
}
