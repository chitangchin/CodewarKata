namespace Solution8Kyu
{
    using NUnit.Framework;
    using Kata.AbbrevName;

    [TestFixture]
    public class AbbreviateTwoWordNameTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(SolutionClass.AbbrevName("Sam Harris"), Is.EqualTo("S.H"));
            Assert.That(SolutionClass.AbbrevName("Patrick Feenan"), Is.EqualTo("P.F"));
            Assert.That(SolutionClass.AbbrevName("Evan Cole"), Is.EqualTo("E.C"));
            Assert.That(SolutionClass.AbbrevName("P Favuzzi"), Is.EqualTo("P.F"));
            Assert.That(SolutionClass.AbbrevName("David Mendieta"), Is.EqualTo("D.M"));
        }
    }
}