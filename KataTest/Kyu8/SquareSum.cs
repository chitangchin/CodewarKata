namespace KataTests.Kyu8
{
    using Kata.Kyu8.SquareSum;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class SquareSumTests
    {
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 2 }).Returns(9);
                yield return new TestCaseData(new int[] { 1, 2 }).Returns(5);
                yield return new TestCaseData(new int[] { 5, 3, 4 }).Returns(50);
                yield return new TestCaseData(new int[] { }).Returns(0);
            }
        }

        [Test, TestCaseSource(nameof(sampleTestCases)), Description("Sample Tests")]
        public int SampleTest(int[] n) => SolutionClass.SquareSum(n);
    }
}
