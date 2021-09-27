using System;
//https://practice.geeksforgeeks.org/problems/minimum-swaps-required-to-bring-all-elements-less-than-or-equal-to-k-together4847/1

namespace Algorithms.GFG
{
    public class MinimumswapsandKtogether
    {
        public static int minSwap(int[] arr, int n, int k)
        {
            int count = 0;
            int good = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] <= k)
                    count++;
            }
            if (count == 0) return 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] <= k) good++;
            }
            int min = count - good;
            for (int i = count; i < n; i++)
            {
                if (arr[i - count] <= k)
                    good--;
                if (arr[i] <= k)
                    good++;
                min = Math.Min(count - good, min);
            }
            return min;
        }
    }
}
