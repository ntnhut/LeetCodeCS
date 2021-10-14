using System;
using System.Collections.Generic;

namespace _279PerfectSquares
{
    public class Solution
    {
        public bool isSquare(int n)
        {
            var sq = (int)Math.Sqrt(n);

            return (sq * sq == n);
        }
        // Due to Lagrange's Four Square Theorem, the result is at most 4.
        public int NumSquares(int n)
        {
            var sq = (int)Math.Sqrt(n);

            if (sq * sq == n)
            {
                return 1;
            }
            // Due to Legendre's three-square theorem, 
            // the result cannot be 1, 2, or 3 if n is of the form n = 4^a(8*b + 7)

            while (n%4==0)
            {
                n /= 4;
            }
            if (n %8 == 7)
            {
                return 4;
            }
            for (int i=1; i<= sq; i++)
            {
                if (isSquare(n - i * i)) return 2;
            }
            return 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var so = new Solution();
            Console.WriteLine(so.NumSquares(12)); // 3 (4 +4 +4)
            Console.WriteLine(so.NumSquares(13)); // 2 (4 + 9)
        }
    }
}
