namespace KataTests.Kyu8
{
    using Kata.Kyu8.GrasshopperSummation;
    using NUnit.Framework;

    [TestFixture]
    public static class GrasshopperSummationTests
    {
        [Test]
        public static void BasicTests()
        {
            Assert.That(SolutionClass.summation(1), Is.EqualTo(1));
            Assert.That(SolutionClass.summation(8), Is.EqualTo(36));
            Assert.That(SolutionClass.summation(22), Is.EqualTo(253));
            Assert.That(SolutionClass.summation(100), Is.EqualTo(5050));
            Assert.That(SolutionClass.summation(213), Is.EqualTo(22791));
        }
    }
}
