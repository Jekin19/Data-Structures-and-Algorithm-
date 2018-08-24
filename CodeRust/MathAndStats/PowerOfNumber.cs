using System;
namespace CodeRust.MathAndStats
{
    public class PowerOfNumber
    {
        public static double Power(double x, int n)
        {
            //TODO: Write - Your - Code

            if (n == 0) return 1;
            if (n == 1) return x;
            bool isNeg = false;
            if (n < 0) {
                n *=-1;
            }
            double temp = x;
            double result = 1;
            while(n > 0) {
                if (n % 2 != 0)
                {
                    result = result * temp;
                }
                temp = temp * temp;
                n = n / 2;
            }

            return isNeg ? 1/result : result;
        }
    }
}
