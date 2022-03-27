using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class Spaceship: ISpaceship
    {
        private readonly IAdapter<Point> _movableAdapter;
        private readonly IAdapter<int> _rotatableAdapter;
        private readonly UObject _uObject;
        public Spaceship(UObject uObject, IAdapter<Point> movableAdapter, IAdapter<int> rotatableAdapter)
        {
            _movableAdapter = movableAdapter;
            _rotatableAdapter = rotatableAdapter;
            _uObject = uObject;
        }
        public void Move(Point p)
        {
           var currentPosition = _movableAdapter.Execute(_uObject, p);
            _uObject.Position = currentPosition;
        }
           

        public void Rotate(int direction)
        {
            var currentPosition = _rotatableAdapter.Execute(_uObject, direction);
            _uObject.Position = currentPosition;

        }

        public Point GetCurrentPosition()
            => _uObject.Position;

    }
}
