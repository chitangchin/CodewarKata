﻿namespace Solution8Kyu
{
    using Kata.ReversedString;
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