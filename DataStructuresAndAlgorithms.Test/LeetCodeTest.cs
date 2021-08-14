using System;
using System.Linq;
using Algorithms;
using Algorithms.Leetcode;
using DataStructures;
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
        [InlineData(new int[] { 4, 2, 0, 3, 2, 5 }, 9)]
        [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
        public void TrappingRainWater_Test(int[] input, int output)
        {
            Assert.Equal(TrappingRainWater.Solve(input), output);
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

        [Theory]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("{[]}", true)]
        public void ValidParentheses_Test(string input, bool output)
        {
            Assert.Equal(ValidParentheses.Solve(input), output);
        }

        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        [InlineData("aabb", -1)]
        public void FirstUniqueCharacter_Test(string input, int output)
        {
            Assert.Equal(FirstUniqueCharacter.Solve(input), output);
        }

        [Theory]
        [InlineData("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" }, "ball")]
        [InlineData("a.", new string[] { }, "a")]
        public void MostCommonWord_Test(string input, string[] banned, string ans)
        {
            Assert.Equal(MostCommonWord.Solve(input, banned), ans);
        }

        [Theory]
        [InlineData(new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" }, new string[] { "let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6" })]
        [InlineData(new string[] { "1 n u", "r 527", "j 893", "6 14", "6 82" }, new string[] { "1 n u", "r 527", "j 893", "6 14", "6 82" })]
        public void ReorderDataInLogFiles_Test(string[] input, string[] ans)
        {
            Assert.Equal(ReorderDataInLogFiles.Solve(input), ans);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1})]
        [InlineData(new int[] { 1 ,2, 3 }, new int[] { 3,2,1})]
        public void ReverseLinkedList_Test(int[] input, int[] output)
        {
            ListNode dummyInput = new ListNode(0);
            ListNode dummyOutPut = new ListNode(0);
            for (int i = 0; i < input.Length; i++,dummyOutPut = dummyOutPut.next,dummyInput=dummyInput.next)
            {
                dummyInput.next = new ListNode(input[i]);
                dummyOutPut.next = new ListNode(output[output.Length-i-1]);

            }
            ListNode ansIterativeHead = ReverseLinkedList.SolveIterative(dummyInput.next);
            ListNode ansRecursiveHead = ReverseLinkedList.SolveIterative(dummyOutPut.next);
            Assert.Equal(ansIterativeHead, dummyOutPut.next);
            Assert.Equal(ansRecursiveHead, dummyOutPut.next);
        }
    }
}
