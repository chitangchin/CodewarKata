using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTest.Kyu8
{
    using NUnit.Framework;
    using Kata.BeginnerReduceButGrow;

    [TestFixture]
    public class BeginnerReduceButGrowTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(SolutionClass.Grow(new[] { 1, 2, 3 }), Is.EqualTo(6));
            Assert.That(SolutionClass.Grow(new[] { 4, 1, 1, 1, 4 }), Is.EqualTo(16));
            Assert.That(SolutionClass.Grow(new[] { 2, 2, 2, 2, 2, 2 }), Is.EqualTo(64));
        }
    }
}
