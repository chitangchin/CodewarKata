namespace KataTests.Kyu8
{
    using Kata.CountingSheep;
    using NUnit.Framework;

    [TestFixture]
    public class CountSheepsTests
    {

        [Test]
        public void SampleTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, SolutionClass.CountSheeps(sheeps));
        }
    }
}
