﻿using Kata.EvenOrOdd;

namespace Solution
{
    [TestFixture]
    public class EvenOrOddTests
    {
        [TestCase(1)]
        [TestCase(7)]
        public void PositiveOddTest(int num)
        {
            Assert.That(SolutionClass.EvenOrOdd(num), Is.EqualTo("Odd"));
        }

        [TestCase(2)]
        [TestCase(42)]
        public void PositiveEvenTest(int num)
        {
            Assert.That(SolutionClass.EvenOrOdd(num), Is.EqualTo("Even"));
        }

        [TestCase(-1)]
        [TestCase(-7)]
        public void NegativeOddTest(int num)
        {
            Assert.That(SolutionClass.EvenOrOdd(num), Is.EqualTo("Odd"));
        }

        [TestCase(-2)]
        [TestCase(-42)]
        public void NegativeEvenTest(int num)
        {
            Assert.That(SolutionClass.EvenOrOdd(num), Is.EqualTo("Even"));
        }

        [Test]
        public void ZeroIsEvenTest()
        {
            Assert.That(SolutionClass.EvenOrOdd(0), Is.EqualTo("Even"));
        }
    }
}