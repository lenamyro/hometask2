using SpaceButtleHomeTask2;
using System.Drawing;

var directionNumber = 8;
var velocity = 0;


var movableAdapter = new MovableAdapter(new Motion());
var rotatbleAdapter = new RotatableAdapter(new Rotation(velocity, directionNumber));


var spaceShip = new Spaceship(movableAdapter, rotatbleAdapter);
spaceShip.Move(new Point(-7, 3));
spaceShip.Rotate(5);

