namespace KataTests.Kyu8
{
    using Kata.Quadrant;
    using NUnit.Framework;

    [TestFixture]
    public class QuadrantTests
    {
        static void Act(int x, int y, int expected) => Assert.That(SolutionClass.Quadrant(x, y), Is.EqualTo(expected), $"Quadrant( x = {x}, y = {y} )");

        [TestCase(1, 2, 1)]
        [TestCase(3, 5, 1)]
        [TestCase(-10, 100, 2)]
        [TestCase(-1, -9, 3)]
        [TestCase(19, -56, 4)]
        [TestCase(1, 1, 1)]
        [TestCase(-60, -12, 3)]
        public void FixedTests(int x, int y, int expected) => Act(x, y, expected);
    }
}