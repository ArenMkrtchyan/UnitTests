using UnitTests;

namespace Testing
{
    public class Tests
    {
       private Triangle _triangle;
        private Circle _circle;
        
        [SetUp]
        public void Setup()
        {
            _triangle = new Triangle(3,4,5);
            _circle = new Circle(5);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(6, _triangle.GetArea);
           // Assert.AreEqual(5 * 5 * Math.PI, _circle.GetArea);

            Assert.Pass();
        }
    }
}