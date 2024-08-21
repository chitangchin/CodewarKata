#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace KataTests.Kyu7
#pragma warning restore IDE0130 // Namespace does not match folder structure
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
