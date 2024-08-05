namespace Solution8Kyu
{
    using Kata.StringRepeat;
    using NUnit.Framework;
    using Microsoft.VisualStudio.TestPlatform.TestHost;

    [TestFixture]
    public class StringRepeatTests
    {
        [Test(Description = "Fixed Tests")]
        public void FixedTests()
        {
            Assert.That(SolutionClass.RepeatStr(3, "*"), Is.EqualTo("***"));
            Assert.That(SolutionClass.RepeatStr(5, "#"), Is.EqualTo("#####"));
            Assert.That(SolutionClass.RepeatStr(2, "ha "), Is.EqualTo("ha ha "));
        }
    }
}