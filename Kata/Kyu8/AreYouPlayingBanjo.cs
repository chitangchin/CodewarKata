using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Kyu8.AreYouPlayingBanjo
{

    public class SolutionClass
    {
        public static string AreYouPlayingBanjo(string name)
        {
            //Implement me
            if (name[0] == 'r' || name[0] == 'R') return $"{name} plays banjo";
            return $"{name} does not play banjo";
        }
    }
}
