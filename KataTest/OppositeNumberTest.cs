using Kata.Opposite;

namespace Solution
{
    using NUnit.Framework;

    [TestFixture]
    public class OppositeNumberTests
    {
        [Test]
        public void Test_1()
        {
            Assert.That(SolutionClass.Opposite(1), Is.EqualTo(-1));
        }
    }
}
