using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace TDDProject.Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Rotate_ShouldReturnPoint()
        {
            //ARRANGE
            Compass compass = new Compass();
            Point testPoint = Point.NORTH;
            Direction testDirection = Direction.RIGHT;

            //ACT
            Point result = Rotate(testPoint, testDirection);

            //ASSERT
            Assert.That(result, Is.EqualTo(Point.EAST));

        }
    }
}