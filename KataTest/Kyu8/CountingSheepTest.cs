namespace KataTests.Kyu8
{
    using Kata.Kyu8.CountingSheep;
    using NUnit.Framework;

    [TestFixture]
    public class CountSheepsTests
    {

        [Test]
        public void SampleTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.That(SolutionClass.CountSheeps(sheeps), Is.EqualTo(2));
        }
    }
}
