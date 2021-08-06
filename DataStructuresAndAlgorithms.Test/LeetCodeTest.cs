using System;
using System.Linq;
using Algorithms;
using Algorithms.Leetcode;
using Xunit;

namespace DataStructureAndAlgorithms.Test
{
    public class LeetCodeTest
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void StockBuySell_Test(int[] prices, int ans)
        {
            Assert.Equal(StockBuySellII.MaxProfitBF(prices), ans);
            Assert.Equal(StockBuySellII.MaxProfitBF(prices), ans);
            Assert.Equal(StockBuySellII.MaxProfitOptimized(prices), ans);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void RemoveDuplicate_Test(int[] nums, int ans)
        {
            Assert.Equal(RemoveDuplicate.RemoveDuplicatesSol(nums), ans);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 2)]
        public void RoatateArray_Test(int[] arr, int k)
        {
            var input = (int[])arr.Clone();
            var arrayRotate = new RotateArray();
            arrayRotate.RotateByK(arr, k);
            for (int i = 0, j = k; i < arr.Length; i++, j++)
            {
                Assert.Equal(input[i], arr[j % arr.Length]);
            }

        }

        [Theory]
        [InlineData(40, "XL")]
        [InlineData(9, "IX")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void IntegerToRoman_Test(int num, string s)
        {
            Assert.Equal(IntegerToRoman.Solve(num), s);
        }

        [Theory]
        [InlineData("eceba", 3)]
        [InlineData("ccaabbb", 5)]
        public void LengthOfLongestSubstringTwoDistinct_Test(string s, int ans)
        {
            Assert.Equal(LengthOfLongestSubstringTwoDistinct.Solve(s), ans);
        }

        [Theory]
        [InlineData(new string[] { "mission statement",
                "a quick bite to eat",
                "a chip off the old block",
                "chocolate bar",
                "mission impossible",
                "a man on a mission",
                "block party",
                "eat my words",
                "bar of soap" },
            new string[]{"a chip off the old block party",
                "a man on a mission impossible",
                "a man on a mission statement",
                "a quick bite to eat my words",
                "chocolate bar of soap" })]
        [InlineData(new string[] { "a", "b", "a" },
            new string[] { "a" })]

        public void BeforeAndAfterPuzzles_Test(string[] input, string[] output)
        {
            Assert.Equal(BeforeAndAfterPuzzles.Solve(input).ToArray(), output);
        }
    }
}
