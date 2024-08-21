namespace KataTests.Kyu8
{
    using Kata.BeginnerReduceButGrow;
    using NUnit.Framework;

    [TestFixture]
    public class BeginnerReduceButGrowTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(SolutionClass.Grow(new[] { 1, 2, 3 }), Is.EqualTo(6));
            Assert.That(SolutionClass.Grow(new[] { 4, 1, 1, 1, 4 }), Is.EqualTo(16));
            Assert.That(SolutionClass.Grow(new[] { 2, 2, 2, 2, 2, 2 }), Is.EqualTo(64));
        }
    }
}
