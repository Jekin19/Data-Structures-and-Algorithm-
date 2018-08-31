using System;
namespace CodeRust.MathAndStats
{
    public class IntegerDivision
    {
        public static int IntegerDivisionRec(int dividend, int divisor){
            if (divisor == 0) return -1;
            if (divisor == 1) return dividend;
            if (dividend < divisor) return 0;
            if (divisor == dividend) return 1;

            int temp = divisor;
            int quotient = 1;
            while(dividend > temp) {
                temp = temp * 2;
                quotient = quotient * 2;
            }
            if(temp > dividend) {
                temp = temp / 2;
                quotient = quotient / 2;
                return quotient + IntegerDivisionRec(dividend - temp, divisor);
            }
            return quotient;
        }
    }
}
