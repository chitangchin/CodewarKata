using Kata.Multiply;
namespace Solution8Kyu
{
    [TestFixture]
    public class CustomMathTests
    {
        [Test]
        public void ShouldMultiple()
        {
            Assert.That(CustomMath.multiply(2, 1), Is.EqualTo(2));
            Assert.That(CustomMath.multiply(2, 4), Is.EqualTo(8));
        }
    }

}