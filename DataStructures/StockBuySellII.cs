using System;

namespace DataStructures
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

        }
    }
}
