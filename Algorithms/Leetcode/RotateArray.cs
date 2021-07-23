using System;
/// <summary>
/// https://leetcode.com/problems/rotate-array/
/// </summary>
namespace Algorithms.Leetcode
{
    public class RotateArray
    {
        public void RotateByK(int[] arr, int k)
        {
            int n = arr.Length;
            int gcd = GCD(k, arr.Length);
            for (int i = 0; i < gcd; i++)
            {
                int j = i;
                int prev = arr[j];
                do
                {
                    int curr = arr[j];
                    arr[j] = prev;
                    prev = curr;
                    j = (j + k) % n;
                } while (j != i);

                arr[i] = prev;

            }
        }

        private int GCD(int a, int b)
        {
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            int x = Math.Max(a, b);
            int y = Math.Min(a, b);
            return GCD(x - y, y);
        }
    }
}


///[1,2,3,4,5,6,7,8,9,10]
/// 0,1,2,3,4,5,6,7,8,9
/// *   *   *   *   *   