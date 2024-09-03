using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTest.Kyu8
{
    using NUnit.Framework;
    using Kata.Kyu8.AreYouPlayingBanjo;

    [TestFixture]
    public class AreYouPlayingBanjo
    {
        [Test]
        public static void Martin()
        {
            Assert.That(SolutionClass.AreYouPlayingBanjo("Martin"), Is.EqualTo("Martin does not play banjo"));
        }

        [Test]
        public static void Rikke()
        {
            Assert.That(SolutionClass.AreYouPlayingBanjo("Rikke"), Is.EqualTo("Rikke plays banjo"));
        }

        [Test]
        public static void bravo()
        {
            Assert.That(SolutionClass.AreYouPlayingBanjo("bravo"), Is.EqualTo("bravo does not play banjo"));
        }

        [Test]
        public static void rolf()
        {
            Assert.That(SolutionClass.AreYouPlayingBanjo("rolf"), Is.EqualTo("rolf plays banjo"));
        }
    }
}
