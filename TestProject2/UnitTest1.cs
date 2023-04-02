using UnitTests;

namespace TestProject2
{
    public class Tests
    {
        private Circle _circle;
        private Triangle _triangle;
        [SetUp]
        public void Setup()
        {
            _circle = new Circle(5);
            _triangle=new Triangle(3,4,5);
        }

        [Test]
        public void Test1()
        {
           var circleArea= _circle.GetArea;
            var triangleArea=_triangle.GetArea;
            Assert.AreEqual(5*5, circleArea);
           // Assert.AreEqual(6, triangleArea);
        }
    }
}