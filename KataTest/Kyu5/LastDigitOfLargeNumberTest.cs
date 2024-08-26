namespace KataTests.Kyu5
{
    using Kata.Kyu5.LastDigitOfLargeNumber;
    using NUnit.Framework;
    using System.Linq;
    using System.Numerics;

    // TODO: Replace examples and use TDD development by writing your own tests

    [TestFixture]
    public class LastDigitOfLargeNumberTests
    {
        [Test]
        public void Exampletests()
        {
            Assert.That(SolutionClass.GetLastDigit(4, 1), Is.EqualTo(4));
            Assert.That(SolutionClass.GetLastDigit(4, 2), Is.EqualTo(6));
        }
        public void ExampleTests2()
        {
            Assert.That(SolutionClass.GetLastDigit(9, 7), Is.EqualTo(9));
            Assert.That(SolutionClass.GetLastDigit(10, BigInteger.Pow(10, 10)), Is.EqualTo(0));
            Assert.That(SolutionClass.GetLastDigit(BigInteger.Pow(2, 200), BigInteger.Pow(2, 300)), Is.EqualTo(6));
            Assert.That(SolutionClass.GetLastDigit(BigInteger.Parse("3715290469715693021198967285016729344580685479654510946723"), BigInteger.Parse("68819615221552997273737174557165657483427362207517952651")), Is.EqualTo(7));
        }

        [Test]
        public void XPowZero()
        {
            foreach (var d in Enumerable.Range(0, 9))
            {
                Assert.That(SolutionClass.GetLastDigit(d, 0), Is.EqualTo(1));
            }
        }
    }
}
