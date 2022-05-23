using System;

namespace CodingProblems.Leetcode
{
    public class LongestCommonSubsequence
    {
        public static int LCS(string t1, string t2)
        {
            return LCS(t1, t2, 0, 0, 0);
        }

        private static int LCS(string t1, string t2, int i, int j, int c)
        {
            if (t1.Length >= i || t2.Length >= j) return c;

            if (t1[i] == t2[j])
            {
                return LCS(t1, t2, i + 1, j + 1, c + 1);
            }
            else
            {
                return Math.Max(LCS(t1, t2, i + 1, j, c), LCS(t1, t2, i, j + 1, c));
            }
        }

        private static int LCSTabular(string text1, string text2)
        {
            int[,] dp = new int[text1.Length + 1, text2.Length + 1];
            for (int i = 1; i <= text1.Length; i++)
            {
                for (int j = 1; j <= text2.Length; j++)
                {

                    dp[i, j] = (text1[i - 1] == text2[j - 1]) ? 1 + dp[i - 1, j - 1] : Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
            return dp[text1.Length, text2.Length];
        }
    }
}
