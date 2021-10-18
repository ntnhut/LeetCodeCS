using System;

namespace _309BestTimeToBuyAndSellStockWithCooldown
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1)
            {
                return 0;
            }
            int s0 = 0;
            int s1 = -prices[0];
            int s2 = int.MinValue;
            int prevS2;
            for (int i = 1; i < prices.Length; i++)
            {
                prevS2 = s2;
                s2 = s1 + prices[i];
                s1 = Math.Max(s1, s0 - prices[i]);
                s0 = Math.Max(prevS2, s0);
            }
            return Math.Max(s0, s2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var so = new Solution();
            var prices = new int[] { 1, 2, 3, 0, 2};
            Console.WriteLine(so.MaxProfit(prices)); // 3
            prices = new int[] { 1};
            Console.WriteLine(so.MaxProfit(prices)); // 0
        }
    }
}
