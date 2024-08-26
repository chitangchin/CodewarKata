namespace KataTest.Kyu7
{
    using Kata.Kyu7.CategorizeNewMember;
    public class CategorizeNewMemberTest
    {
        [TestFixture]
        public class KataOpenOrSeniorTests
        {
            private static readonly string[] expected = new[] { "Open", "Senior", "Open", "Senior" };

            [Test]
            public void SampleTest()
            {
                Assert.That(SolutionClass.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }), Is.EqualTo(expected));
                Assert.That(SolutionClass.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }), Is.EqualTo(new[] { "Open", "Open", "Open", "Open" }));
                Assert.That(SolutionClass.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }), Is.EqualTo(new[] { "Senior", "Open", "Open", "Open" }));
            }

        }
    }
}
