using System;
namespace CodeRust.MathAndStats
{
    public class IntegerDivision
    {
        public static int IntegerDivisionRec(int dividend, int divisor){
            if (divisor == 0) return -1;
            if (divisor == 1) return dividend;
            if (divisor > dividend) return 0;
            if (divisor == dividend) return 1;

            int quotient = 1;
            int temp = divisor;
            while(dividend > temp) {
                quotient = quotient * 2;
                temp =  temp * 2;
            }

            if(temp > dividend) {
                quotient = quotient / 2;
                temp = temp / 2;
                return quotient + IntegerDivisionRec(dividend - temp, divisor);
            }
            return quotient;
        }
    }
}
