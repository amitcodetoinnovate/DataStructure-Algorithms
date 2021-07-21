using System;
//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
namespace Algorithms
{
    public class StockBuySellII
    {
        public static int MaxProfitBF(int[] prices)
        {
            return MaxProfit(0, prices);
        }

        private static int MaxProfit(int index, int[] prices)
        {
            if (index >= prices.Length)
                return 0;

            int maxProfit = 0;
            for (int i = index; i < prices.Length - 1; i++)
            {
                int tempMaxProfit = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] > prices[i])
                    {
                        int profit = MaxProfit(j + 1, prices) + prices[j] - prices[i];
                        if (tempMaxProfit < profit)
                            tempMaxProfit = profit;
                    }
                }

                if (maxProfit < tempMaxProfit)
                    maxProfit = tempMaxProfit;

            }

            return maxProfit;
        }

        public static int MaxProfitPeak(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int maxProfit = 0, i = 0;

            while (i < prices.Length - 1)
            {
                while (i < prices.Length - 1 && prices[i] >= prices[i + 1])
                    i++;
                int valley = prices[i];
                while (i < prices.Length - 1 && prices[i] <= prices[i + 1])
                    i++;
                int peak = prices[i];
                maxProfit = peak - valley;
            }

            return maxProfit;
        }

        public static int MaxProfitOptimized(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
                if (prices[i] > prices[i - 1])
                    maxProfit += prices[i] - prices[i - 1];

            return maxProfit;
        }
    }
}