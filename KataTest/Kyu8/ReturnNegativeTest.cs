﻿namespace KataTests.Kyu8
{
    using Kata.Kyu8.ReturnNegative;
    [TestFixture]
    public class ReturnNegativeTests
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.MakeNegative(42), Is.EqualTo(-42));
        }
    }
}
