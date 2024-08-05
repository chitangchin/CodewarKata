namespace Solution8Kyu
{
    using Kata.BoolToWord;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class BoolToWordTests
    {

        [Test]
        public void boolToWordReturned1()
        {
            Assert.That(SolutionClass.BoolToWord(true), Is.EqualTo("Yes"));
        }

        [Test]
        public void boolToWordReturned2()
        {
            Assert.That(SolutionClass.BoolToWord(false), Is.EqualTo("No"));
        }

        [Test]
        public void boolToWordReturned3()
        {
            Assert.That(SolutionClass.BoolToWord(true), Is.EqualTo("Yes"));
        }
    }

}
