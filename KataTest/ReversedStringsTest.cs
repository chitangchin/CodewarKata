namespace Solution
{
    using NUnit.Framework;
    using Kata.ReversedString;

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