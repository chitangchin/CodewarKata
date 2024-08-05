using NUnit.Framework;
using System;
using Kata.Multiply;
namespace Solution
{
[TestFixture]
public class CustomMathTests
{
    [Test]
    public void ShouldMultiple()
    {
        Assert.AreEqual(2, CustomMath.multiply(2, 1));
        Assert.AreEqual(8, CustomMath.multiply(2, 4));
    }
}

}