namespace KataTest.Kyu7
{
    using Kata.Kyu7.PrinterErrors;

    [TestFixture]
    public static class PrinterTests
    {

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing PrinterError");
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.That(SolutionClass.PrinterError(s), Is.EqualTo("3/56"));
        }
    }

}
