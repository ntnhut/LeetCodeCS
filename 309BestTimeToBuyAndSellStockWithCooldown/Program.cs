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
            var s0 = new int[prices.Length];
            var s1 = new int[prices.Length];
            var s2 = new int[prices.Length];
            s0[0] = 0;
            s1[0] = -prices[0];
            s2[0] = int.MinValue;

            for (int i = 1; i < prices.Length; i++)
            {
                s0[i] = Math.Max(s2[i-1], s0[i-1]);
                s1[i] = Math.Max(s0[i-1] - prices[i], s1[i-1]);
                s2[i] = s1[i - 1] + prices[i];
            }
            return Math.Max(s0[prices.Length - 1], s2[prices.Length - 1]);
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
