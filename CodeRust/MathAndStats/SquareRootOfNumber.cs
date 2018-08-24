using System;
namespace CodeRust.MathAndStats
{
    public class SquareRootOfNumber
    {
        public const double THRESHOLD = 0.00001;

        public static double GetSquareRoot(double x) {
            if (x <= 0) {
                return -1;
            }
            double end = 1 + x / 2;
            double start = 0;
            while(start < end) {
                double mid = (start + end) / 2;
                if (mid * mid >= x-THRESHOLD && mid * mid <= x+THRESHOLD) {
                    return mid;
                }
               
                if(mid*mid < x) {
                    start = mid;
                } else {
                    end = mid;
                }
            }

            return -1;
        }
    }
}
