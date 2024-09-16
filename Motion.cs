using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class Motion : IMovable
    {
        public Point MoveLinearMotion(Point oldPosition, Point position)
        {
            var x = position.X + oldPosition.X;
            var y = position.Y + oldPosition.X;

            return new Point(x, y);
        }
    }
}
