using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class Rotation : IRotatble
    {
        private readonly int _velocity;
        private readonly int _directionNumber;

        public Rotation(int velocity, int directionNumber )
        {
            _velocity = velocity;
            _directionNumber = directionNumber;
        }

        public Point Rotate(Point oldPosition, int direction)
        {
            var x = oldPosition.X + _velocity * Math.Cos(direction / 360 * _directionNumber);
            var y = oldPosition.Y + _velocity * Math.Cos(direction / 360 * _directionNumber);

            return new Point((int)x, (int)y);
        }
    }
}
