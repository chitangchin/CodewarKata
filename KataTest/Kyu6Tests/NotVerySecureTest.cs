﻿namespace KataTest.Kyu6Tests
{
    using Kata.AbbrevName;
    using NUnit.Framework;
    using Kata.Kyu6;
    using System.Collections.Generic;

  [TestFixture]
  public class Sample_Tests
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData("Mazinkaiser").Returns(true);
        yield return new TestCaseData("hello world_").Returns(false);
        yield return new TestCaseData("PassW0rd").Returns(true);
        yield return new TestCaseData("     ").Returns(false);
      }
    }

        [Test, TestCaseSource("testCases")]
    public bool Test(string str) => Kata.Kyu6.SolutionClass.Alphanumeric(str);
  }
}