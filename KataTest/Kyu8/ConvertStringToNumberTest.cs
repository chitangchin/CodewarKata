namespace KataTests.Kyu8
{
    using Kata.Kyu8.ConvertStringToNumber;
    using NUnit.Framework;

    [TestFixture]
    public class StringToNumberTests
    {
        [Test]
        public void test1()
        {
            Assert.That(SolutionClass.StringToNumber("1234"), Is.EqualTo(1234));
        }

        [Test]
        public void test2()
        {
            Assert.That(SolutionClass.StringToNumber("605"), Is.EqualTo(605));
        }

        [Test]
        public void test3()
        {
            Assert.That(SolutionClass.StringToNumber("1405"), Is.EqualTo(1405));
        }

        [Test]
        public void test4()
        {
            Assert.That(SolutionClass.StringToNumber("-7"), Is.EqualTo(-7));
        }
    }
}
