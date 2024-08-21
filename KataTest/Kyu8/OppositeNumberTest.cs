﻿using Kata.Opposite;

namespace KataTests.Kyu8
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