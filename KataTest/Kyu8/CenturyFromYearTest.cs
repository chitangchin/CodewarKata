﻿namespace KataTests.Kyu8
{
    using Kata.Kyu8.CenturyFromYear;
    using NUnit.Framework;

    [TestFixture]
    public class CenturyFromYearTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(SolutionClass.СenturyFromYear(1705), Is.EqualTo(18));
            Assert.That(SolutionClass.СenturyFromYear(1900), Is.EqualTo(19));
            Assert.That(SolutionClass.СenturyFromYear(1601), Is.EqualTo(17));
            Assert.That(SolutionClass.СenturyFromYear(2000), Is.EqualTo(20));
        }
    }
}