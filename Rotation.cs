using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class Rotation : IRotatble
    {

        public Point Rotate(UObject uObject, int direction)
        {
            var position = uObject.Position;
            var velocity = uObject.Velocity;
            var directionNumber = uObject.DirectionNumber;
            var x = position.X + velocity * Math.Cos(direction / 360 * directionNumber);
            var y = position.Y + velocity * Math.Cos(direction / 360 * directionNumber);

            return new Point((int)x, (int)y);
        }
    }
}
