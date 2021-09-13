using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GFG
{
    public class MinimumNoOfPlatform
    {
        public int findPlatform(int[] arr, int[] dep, int n)
        {
            Array.Sort(arr);
            Array.Sort(dep);
            int i = 0, j = 0;
            int c = 0;
            int max = 0;
            while (i < n && j < n)
            {
                if (arr[i] <= dep[j])
                {
                    c++;
                    i++;

                }
                else
                {
                    c--;
                    j++;
                }
                max = Math.Max(max, c);
            }

            return max;
        }
    }
}
