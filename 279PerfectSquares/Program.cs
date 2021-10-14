using System;
using System.Collections.Generic;

namespace _279PerfectSquares
{
    public class Solution
    {
        Dictionary<int, int> _ns = new Dictionary<int, int>();
        public int NumSquares(int n)
        {
            if (_ns.ContainsKey(n)) return _ns[n];
            var sq = (int)Math.Sqrt(n);

            if (sq * sq == n)
            {
                _ns.Add(n,1);
                return 1;
            }
            int result = n;
            for (int i=1; i<= sq; i++)
            {
                result = Math.Min(result, NumSquares(n - i * i));
            }
            _ns.Add(n, result + 1);
            return _ns[n];
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
