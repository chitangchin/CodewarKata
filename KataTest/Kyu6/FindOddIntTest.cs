using Kata.Kyu6.findIt;

namespace KataTest.Kyu6
{
    using NUnit.Framework;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Tests()
        {
            Assert.That(SolutionClass.Find_it([20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5]), Is.EqualTo(5));
        }
    }
}
