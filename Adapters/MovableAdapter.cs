using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class IAdapter : IAdapter
    {
        private readonly IMovable _movement;

        public MovableAdapter(IMovable movement)
        {
            _movement = movement;
        }

        public Point Execute(Point oldPosition, Direction<Point> newPosition)
             => _movement.MoveLinearMotion(oldPosition, newPosition.Value);
    }
           
}
