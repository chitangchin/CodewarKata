using Kata.Kyu6.YourOrderPlease;

namespace KataTest.Kyu6
{
    public class YourOrderPleaseTest
    {
        [Test]
        public void SampleTest1()
        {
            Assert.Multiple(() =>
            {
                Assert.That(SolutionClass.Order("is2 Thi1s T4est 3a"), Is.EqualTo("Thi1s is2 3a T4est"));
                Assert.That(SolutionClass.Order("4of Fo1r pe6ople g3ood th5e the2"), Is.EqualTo("Fo1r the2 g3ood 4of th5e pe6ople"));
                Assert.That(SolutionClass.Order(""), Is.EqualTo(""));
            });
        }
    }
}
