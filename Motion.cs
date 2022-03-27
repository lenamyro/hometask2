using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class Motion : IMovable
    {
        public Point MoveLinearMotion(UObject uObject, Point position)
        {
            var x = position.X + uObject.Position.X;
            var y = position.Y + uObject.Position.X;

            return new Point(x, y);
        }
    }
}
