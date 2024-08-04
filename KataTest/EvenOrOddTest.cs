using System;
using Kata.EvenOrOdd;
using NUnit.Framework;

namespace Solution
{
    [TestFixture]
    public class EvenOrOddTests
    {
        [TestCase(1)]
        [TestCase(7)]
        public void PositiveOddTest(int num)
        {
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(num));
        }

        [TestCase(2)]
        [TestCase(42)]
        public void PositiveEvenTest(int num)
        {
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(num));
        }

        [TestCase(-1)]
        [TestCase(-7)]
        public void NegativeOddTest(int num)
        {
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(num));
        }

        [TestCase(-2)]
        [TestCase(-42)]
        public void NegativeEvenTest(int num)
        {
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(num));
        }

        [Test]
        public void ZeroIsEvenTest()
        {
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(0));
        }
    }
}