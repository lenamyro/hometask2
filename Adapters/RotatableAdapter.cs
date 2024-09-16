using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class RotatableAdapter : IAdapter
    {
        IRotatble _rotation;
        public RotatableAdapter(IRotatble rotation)
        {
            _rotation = rotation;
        }


        public Point Execute(Point oldPosition, Direction<int> direction)
            => _rotation.Rotate(oldPosition, direction.Value);
    }
}
