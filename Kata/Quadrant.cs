using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Quadrant
{
public class SolutionClass
    {
        public static int Quadrant(int x, int y)
        {
            /*
             Find the quadrant the x and y exist in
            first quadrant = +x +y
            second quadrant = -x +y
            third quadrant = -x -y
            fourth quadrant = +x -y

            if (x && y > 0)
            else if (x && y < 0)
            else if (x > 0)
            else ()
             
             */
            int quadrantNumber = 0;

            if (x > 0 &&  y > 0)
            {
                quadrantNumber = 1;
            }
            if (x < 0 && y > 0)
            {
                quadrantNumber = 2;
            }
            if (x < 0 && y < 0)
            {
                quadrantNumber = 3;
            }
            if (x > 0 && y < 0)
            {
                quadrantNumber = 4;
            }
            return quadrantNumber ;
        }
    }
}
