using System;
using Algorithms;
using Algorithms.Leetcode;
using Xunit;
//https://leetcode.com/problems/remove-duplicates-from-sorted-array/

namespace DataStructureAndAlgorithms.Test
{
    public class LeetCodeTest
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void StockBuySell_Test(int[] prices,int ans)
        {
            Assert.Equal(StockBuySellII.MaxProfitBF(prices),ans);
            Assert.Equal(StockBuySellII.MaxProfitBF(prices),ans);
            Assert.Equal(StockBuySellII.MaxProfitOptimized(prices),ans);
        }
        
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void RemoveDuplicate_Test(int[] nums, int ans)
        {
            Assert.Equal(RemoveDuplicate.RemoveDuplicatesSol(nums), ans);
        }
    }
}
