//https://leetcode.com/problems/trapping-rain-water/
using System;

namespace CodingProblems.Leetcode
{
    public class TrappingRainWater
    {
        public static int Solve(int[] height)
        {
            int lMax = 0;
            int rMax = 0;
            int c = 0;
            int n = height.GetLength(0);
            if (n == 0)
                return 0;
            int[] leftMax = new int[n];
            int[] rightMax = new int[n];
            leftMax[0] = 0;
            rightMax[n - 1] = 0;
            for (int i = 1; i < height.GetLength(0); i++)
            {
                lMax = Math.Max(lMax, height[i - 1]);
                leftMax[i] = lMax;
                rMax = Math.Max(rMax, height[n - i]);
                rightMax[n - i - 1] = rMax;
            }
            for (int i = 1; i < height.GetLength(0) - 1; i++)
            {
                int min = Math.Min(rightMax[i], leftMax[i]);
                if (min - height[i] > 0)
                    c = c + min - height[i];
            }
            return c;

        }
    }
}
