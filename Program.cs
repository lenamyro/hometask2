using SpaceButtleHomeTask2;
using System.Drawing;

var directionNumber = 8;


var uObject = new UObject()
{
    Position = new Point(0, 0),
    Velocity = 0,
    DirectionNumber = 8
};

var movableAdapter = new MovableAdapter(new Motion());
var rotatbleAdapter = new RotatableAdapter(new Rotation());


var spaceShip = new Spaceship(uObject, movableAdapter, rotatbleAdapter);
spaceShip.Move(new Point(-7, 3));
spaceShip.Rotate(5);

