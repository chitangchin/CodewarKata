namespace Solution8Kyu
{
    using NUnit.Framework;
    using Kata.CountingSheep;

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
