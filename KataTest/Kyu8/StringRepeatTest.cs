﻿namespace KataTests.Kyu8
{
    using Kata.Kyu8.StringRepeat;
    using NUnit.Framework;

    [TestFixture]
    public class StringRepeatTests
    {
        [Test(Description = "Fixed Tests")]
        public void FixedTests()
        {
            Assert.That(SolutionClass.RepeatStr(3, "*"), Is.EqualTo("***"));
            Assert.That(SolutionClass.RepeatStr(5, "#"), Is.EqualTo("#####"));
            Assert.That(SolutionClass.RepeatStr(2, "ha "), Is.EqualTo("ha ha "));
        }
    }
}