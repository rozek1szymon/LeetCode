using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_to_Buy_and_Sell_StockwithCooldown
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 1) return 0;

            int b0 = -prices[0], b1 = b0;
            int s0 = 0, s1 = 0, s2 = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                b0 = Math.Max(b1, s2 - prices[i]);
                s0 = Math.Max(s1, b1 + prices[i]);
                b1 = b0;
                s2 = s1;
                s1 = s0;
            }
            return s0;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            int[] table = { 4,5 , 3, 5, 2,1,80 };
            solution.MaxProfit(table);
        }
    }
}
