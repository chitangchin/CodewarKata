namespace KataTests.Kyu8
{
    using Kata.RemoveStringSpace;
    using NUnit.Framework;

    [TestFixture]
    public class RemoveStringSpaceTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.That(SolutionClass.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"), Is.EqualTo("8j8mBliB8gimjB8B8jlB"));
            Assert.That(SolutionClass.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"), Is.EqualTo("88Bifk8hB8BB8BBBB888chl8BhBfd"));
            Assert.That(SolutionClass.NoSpace("8aaaaa dddd r     "), Is.EqualTo("8aaaaaddddr"));
        }
    }
}