using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace TDDProject.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Rotate_ShouldReturnPoint()
        {
            //ARRANGE
            Compass compass = new Compass();
            Point testPoint = Point.NORTH;
            Direction testDirection = Direction.RIGHT;

            //ACT
            Point result1 = compass.Rotate(Point.WEST, testDirection);
            Point result2 = compass.Rotate(Point.NORTH, testDirection);
            Point result3 = compass.Rotate(Point.EAST, testDirection);
            Point result4 = compass.Rotate(Point.SOUTH, testDirection);

            //ASSERT
            Assert.Multiple(() =>
            {
                Assert.That(result1, Is.EqualTo(Point.NORTH));
                Assert.That(result2, Is.EqualTo(Point.EAST));
                Assert.That(result3, Is.EqualTo(Point.SOUTH));
                Assert.That(result4, Is.EqualTo(Point.WEST));
            });

        }

    }
}