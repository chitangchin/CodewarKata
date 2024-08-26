namespace KataTests.Kyu8
{
    using Kata.Kyu8.ReversedString;
    using NUnit.Framework;

    [TestFixture]
    public class ReversedStringsTests
    {
        [Test]
        public void World()
        {
            Assert.That(SolutionClass.Solution("world"), Is.EqualTo("dlrow"));
        }
    }
}