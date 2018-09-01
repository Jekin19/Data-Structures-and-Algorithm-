using System;
namespace CodeRust.DynamicProgramming
{
    public class Fibonacci
    {
        public static int GetFibonacci(int n) {
            if (n < 0) return -1;
            int previous = 0;
            int current = 1;
            for (int i = 1; i <= n; i++) {
                int temp = current;
                current = current + previous;
                previous = temp;
            }
            return previous;
        }
    }
}
