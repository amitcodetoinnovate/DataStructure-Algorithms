using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class Fibonacci
    {
        // F(n) = F(n-1) + F(n-2)

        public static int FindFib(int n)
        {
            if(n==1 || n == 2)
            {
                return 1;
            }
            else
            {
                return FindFib(n - 1) + FindFib(n - 2);
            }
        }

        public static void MainFib(int n)
        {
            System.Diagnostics.Debug.Write(FindFib(n));

        }
    }
}
