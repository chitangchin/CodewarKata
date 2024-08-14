namespace KataTest.Kyu7Tests
{
    using NUnit.Framework;
    using Kata.ReverseWords;

    [TestFixture]
    public class ReverseWordsTest
    {
        [Test]
        public void Example()
        {
            Assert.That(SolutionClass.ReverseWords("This is an example!"), Is.EqualTo("sihT si na !elpmaxe"));
        }
    }
}
