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

        [Theory]
        [InlineData("ADOBECODEBANC", "ABC", "BANC")]
        [InlineData("bdab", "ab", "ab")]
        public void MinimumWindowSubstring_Test(string s, string t, string ans)
        {
            Assert.Equal(MinimumWindowSubstring.Solve(s, t), ans);
        }

        [Theory]
        [InlineData("1.01", "1.001", 0)]
        [InlineData("1.0", "1.0.0", 0)]
        [InlineData("0.1", "1.1", -1)]
        [InlineData("1.0.1", "1", 1)]

        public void CompareVersionNumbers_Test(string version1, string version2, int ans)
        {
            Assert.Equal(CompareVersionNumbers.Solve(version1, version2), ans);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
        public void ProductExceptSelf_Test(int[] input, int[] output)
        {
            Assert.Equal(ProductExceptSelf.Solve(input), output);
        }

        [Theory]
        [InlineData(new int[] { 3, 0, 1 }, 2)]
        [InlineData(new int[] { 0, 1 }, 2)]
        [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        public void MissingNumber_Test(int[] input, int output)
        {
            Assert.Equal(MissingNumber.Solve(input), output);
        }

        [Theory]
        [InlineData(123, "One Hundred Twenty Three")]
        [InlineData(12345, "Twelve Thousand Three Hundred Forty Five")]
        [InlineData(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
        [InlineData(1234567891, "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One")]
        public void IntegerToEnglishWords_Test(int input, string output)
        {
            Assert.Equal(IntegerToEnglishWords.Solve(input), output);
        }
    }
}
