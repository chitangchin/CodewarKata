namespace KataTests.Kyu8
{
    using Kata.Kyu8.BasicMathOperation;
    using NUnit.Framework;

    [TestFixture]
    public class BasicMathOperationTests
    {
        [Test]
        public void StaticTests()
        {
            Assert.That(SolutionClass.basicOp('+', 4, 7), Is.EqualTo(11));
            Assert.That(SolutionClass.basicOp('-', 15, 18), Is.EqualTo(-3));
            Assert.That(SolutionClass.basicOp('*', 5, 5), Is.EqualTo(25));
            Assert.That(SolutionClass.basicOp('/', 49, 7), Is.EqualTo(7));
        }
    }
}