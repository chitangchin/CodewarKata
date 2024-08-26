namespace KataTests.Kyu8
{
    using Kata.Kyu8.RemoveChar;
    using NUnit.Framework;

    [TestFixture]
    public class RemoveFirstAndLastChar
    {
        [Test]
        public void Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", SolutionClass.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", SolutionClass.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", SolutionClass.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", SolutionClass.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", SolutionClass.Remove_char("ok"));
        }
    }
}
