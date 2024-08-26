using Kata.Kyu6.SpinWords;

namespace KataTest.Kyu6
{
    [TestFixture]
    public class SpinWords
    {
        [Test]
        public static void Test1()
        {
            Assert.That(SolutionClass.SpinWords("Welcome"), Is.EqualTo("emocleW"));
        }

        [Test]
        public static void Test2()
        {
            Assert.That(SolutionClass.SpinWords("Hey fellow warriors"), Is.EqualTo("Hey wollef sroirraw"));
        }

        [Test]
        public static void Test3()
        {
            Assert.That(SolutionClass.SpinWords("This is a test"), Is.EqualTo("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.That(SolutionClass.SpinWords("This is another test"), Is.EqualTo("This is rehtona test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.That(SolutionClass.SpinWords("You are almost to the last test"), Is.EqualTo("You are tsomla to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.That(SolutionClass.SpinWords("Just kidding there is still one more"), Is.EqualTo("Just gniddik ereht is llits one more"));
        }
    }
}
