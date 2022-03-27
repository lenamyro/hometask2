using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class MovableAdapter : IAdapter<Point>
    {
        private readonly IMovable _movement;

        public MovableAdapter(IMovable movement)
        {
            _movement = movement;
        }

        public Point Execute(UObject uObject, Point newPoint)
            => _movement.MoveLinearMotion(uObject, newPoint);
    }
}
