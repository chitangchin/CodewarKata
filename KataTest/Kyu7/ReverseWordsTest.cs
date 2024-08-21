namespace KataTests.Kyu7
{
    using Kata.ReverseWords;
    using NUnit.Framework;

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
