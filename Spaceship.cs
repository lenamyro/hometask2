using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;

namespace SpaceButtleHomeTask2
{
    public class Spaceship: ISpaceship
    {
        private Point _currentPosition;

        private readonly IAdapter _movableAdapter;
        private readonly IAdapter _rotatableAdapter;
        public Spaceship(IAdapter movableAdapter, IAdapter rotatableAdapter, Point? currentPosition = null)
        {
            _movableAdapter = movableAdapter;
            _rotatableAdapter = rotatableAdapter;

            if (currentPosition != null)
                _currentPosition = currentPosition.Value;

            _currentPosition = new Point(0, 0);
        }

        public void Move(Point p)
        {
           var currentPosition = _movableAdapter.Execute(GetCurrentPosition(), new Direction<Point>()
               {
                   Value = p
               });
            _currentPosition = currentPosition;
        }
           

        public void Rotate(int direction)
        {
            var currentPosition = _rotatableAdapter.Execute(GetCurrentPosition(), , new Direction<int>()
            {
                Value = direction
            });

            _currentPosition = currentPosition;

        }

        public Point GetCurrentPosition()
            => _currentPosition;

    }
}
