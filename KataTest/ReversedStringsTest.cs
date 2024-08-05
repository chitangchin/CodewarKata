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
            Assert.AreEqual("dlrow", SolutionClass.Solution("world"));
        }
    }
}