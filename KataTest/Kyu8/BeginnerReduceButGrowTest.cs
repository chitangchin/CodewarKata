namespace KataTests.Kyu8
{
    using Kata.Kyu8.BeginnerReduceButGrow;
    using NUnit.Framework;

    [TestFixture]
    public class BeginnerReduceButGrowTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.Multiple(() =>
            {
                Assert.That(SolutionClass.Grow([1, 2, 3]), Is.EqualTo(6));
                Assert.That(SolutionClass.Grow([4, 1, 1, 1, 4]), Is.EqualTo(16));
                Assert.That(SolutionClass.Grow([2, 2, 2, 2, 2, 2]), Is.EqualTo(64));
            });
        }
    }
}
