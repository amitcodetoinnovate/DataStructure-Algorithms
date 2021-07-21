using System;
using Algorithms;
using Xunit;

namespace TestDSAlgo
{
    public class LeetCodeTest
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void StockBuySell(int[] prices,int ans)
        {
            Assert.Equal(StockBuySellII.MaxProfitBF(prices),ans);
            Assert.Equal(StockBuySellII.MaxProfitBF(prices),ans);
        }
    }
}
