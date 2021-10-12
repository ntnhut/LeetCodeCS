using System;

namespace _374GuessNumberHigherOrLower
{
    public class GuessGame
    {
        protected int _pick { get; set; }
        public int guess(int num)
        {
            if (num == _pick) return 0;
            if (num > _pick) return -1;
            return 1;
        }

    }
    public class Solution : GuessGame
    {
        public Solution(int pick) 
        {
            _pick = pick;
        }
        public int GuessNumber(int n)
        {
            int min = 1;
            int max = n;
            while (min<=max)
            {
                int mid = (max - min) / 2 + min;
                int compare = guess(mid);
                if (compare==0)
                {
                    return mid;
                } else if (compare<0)
                {
                    max = mid - 1;
                } else
                {
                    min = mid + 1;
                }

            }
            return 0;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var so = new Solution(170276671);
            Console.WriteLine(so.GuessNumber(212675339));
        }
    }
}
