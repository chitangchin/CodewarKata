using Kata.ReturnNegative;

namespace Solution
{

    [TestFixture]
    public class ReturnNegativeTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-42, SolutionClass.MakeNegative(42));
        }
    }
}
