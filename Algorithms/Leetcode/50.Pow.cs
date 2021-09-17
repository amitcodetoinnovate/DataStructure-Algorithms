using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class Power
    {
        public static double MyPow(double x, int n)
        {
            double ans = 1.0;
            long nn = n;
            if (nn < 0) nn = (-1) * nn;
            while (nn>0)
            {
                if (nn % 2 == 1)
                {
                    ans = ans * x;
                    nn--;
                }
                else
                {
                    x = x * x;
                    nn = nn / 2;
                }
            }

            if (n < 0)
                ans = (double)(1.0) / (double)ans;
            return ans;

        }
        
    }
}
