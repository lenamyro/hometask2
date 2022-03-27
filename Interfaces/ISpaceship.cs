using System.Drawing;

namespace SpaceButtleHomeTask2.Interfaces
{
    public interface ISpaceship
    {
        void Move(Point val);
        void Rotate(int direction);
        Point GetCurrentPosition();
    }
}
