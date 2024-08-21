namespace KataTests.Kyu5
{
    using Kata.LastDigitOfLargeNumber;
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
            Assert.AreEqual(4, SolutionClass.GetLastDigit(4, 1));
            Assert.AreEqual(6, SolutionClass.GetLastDigit(4, 2));
        }
        public void ExampleTests2()
        {
            Assert.AreEqual(9, SolutionClass.GetLastDigit(9, 7));
            Assert.AreEqual(0, SolutionClass.GetLastDigit(10, BigInteger.Pow(10, 10)));
            Assert.AreEqual(6, SolutionClass.GetLastDigit(BigInteger.Pow(2, 200), BigInteger.Pow(2, 300)));
            Assert.AreEqual(7, SolutionClass.GetLastDigit(BigInteger.Parse("3715290469715693021198967285016729344580685479654510946723"), BigInteger.Parse("68819615221552997273737174557165657483427362207517952651")));
        }

        [Test]
        public void XPowZero()
        {
            foreach (var d in Enumerable.Range(0, 9))
            {
                Assert.AreEqual(1, SolutionClass.GetLastDigit(d, 0));
            }
        }
    }
}
