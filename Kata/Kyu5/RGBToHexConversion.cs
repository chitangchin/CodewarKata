namespace Kata.Kyu5.RGBToHexConversion
{
    public class SolutionClass
    {
        public static string Rgb(int r, int g, int b)
        {
            //Understand how does RGB get converted to hexadecimal?
            /*
             * Brute Force Approach
            string firstDec = r.ToString("X");
            string secondDec = g.ToString("X");
            string thirdDec = b.ToString("X");
            if (r >= 255) firstDec = "FF";
            if (g >= 255) secondDec = "FF";
            if (b >= 255) thirdDec = "FF";
            if (r <= 0) firstDec = "00";
            if (g <= 0) secondDec = "00";
            if (b <= 0) thirdDec = "00";
            if (r > 0 && r < 16) firstDec = "0" + firstDec;
            if (g > 0 && g < 16) secondDec = "0" + secondDec;
            if (b > 0 && b < 16) thirdDec = "0" + thirdDec;
            return firstDec + secondDec + thirdDec;
            */

            //Optimized code
            if (r < 0) r = 0;
            if (r > 255) r = 255;
            if (g < 0) g = 0;
            if (g > 255) g = 255;
            if (b < 0) b = 0;
            if (b > 255) b = 255;

            //Format the string in hexadecimal using X2 arg with ToString() method
            return r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
        }
    }
}
