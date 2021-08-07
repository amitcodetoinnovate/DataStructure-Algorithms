using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/compare-version-numbers/
namespace Algorithms.Leetcode
{
    public class CompareVersionNumbers
    {
        public static int Solve(string version1, string version2)
        {
            string[] vOne = version1.Split(".");
            string[] vTwo = version2.Split(".");
            int n1 = vOne.Length;
            int n2 = vTwo.Length;
            for (int i = 0; i < Math.Max(n1, n2); i++)
            {

                int i1 = i < n1 ? Convert.ToInt32(vOne[i]) : 0;
                int i2 = i < n2 ? Convert.ToInt32(vTwo[i]) : 0;
                if (i1 != i2)
                {
                    return i1 > i2 ? 1 : -1;
                }
            }

            return 0;

        }

    }
}
