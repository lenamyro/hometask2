using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class RotatableAdapter : IAdapter<int>
    {
        IRotatble _rotation;
        public RotatableAdapter(IRotatble rotation)
        {
            _rotation = rotation;
        }


        public Point Execute(UObject uObject, int direction)
            => _rotation.Rotate(uObject, direction);
    }
}
