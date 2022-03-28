using Moq;
using SpaceButtleHomeTask2.Interfaces;
using System.Drawing;
using Xunit;

namespace SpaceButtleHomeTask2.Tests
{
    public  class SpaceshipTests
    {

        [Fact]
        [Trait("Category", "Unit")]
        public void Test_Spaceship_Move_Should_Return_Ok()
        {
            var currentPosition = new Point(12, 5);
            var newPosition = new Point(-7, 3);

            var expectedPoint = new Point(5, 8);

            var movableAdapterMock = new Mock<IAdapter>();
            var rotableAdapterMock = new Mock<IAdapter>();

            var spaceship = new Spaceship(movableAdapterMock.Object, rotableAdapterMock.Object);

            spaceship.Move(currentPosition);
            spaceship.Move(newPosition);
            var position = spaceship.GetCurrentPosition();

            Assert.Equal(expectedPoint, position);


        }
    }
}
