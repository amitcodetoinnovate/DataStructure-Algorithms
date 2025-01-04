using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class _3266FinalArrayStateAfterKMultiplicationOperationsII
    {

        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            if(multiplier == 1) return nums;
            long mod = 1000000007;
            
            var pq = new PriorityQueue<(long val, int i), (long val, int i)>(Comparer<(long val, int i)>.Create((x, y) => x.val.CompareTo(y.val) != 0 ? x.val.CompareTo(y.val) : x.i.CompareTo(y.i)));
            int n = nums.Length;
            for (int i = 0; i < n; i++) pq.Enqueue((nums[i], i), (nums[i], i));
            
            var m = new Dictionary<int, int>();
            var m1 = new Dictionary<int, int>();


            while (true)
            {
                if (m1.Count == n || k == 0)
                    break;
                (long val, int i) = pq.Dequeue();
                pq.Enqueue((val * multiplier, i), (val * multiplier, i));
                if (!m1.ContainsKey(i))
                    m1.Add(i, 0);
                m1[i]++;
                k--;
            }
            var temp = new long[n];
            while(pq.Count != 0)
            {
                (long val, int i) = pq.Dequeue();
                temp[i] = val;
            }

            int rep = k / n, rem = k % n;
            
            for (int i = 0; i < n; i++) pq.Enqueue((temp[i], i), (temp[i], i));
            while (pq.Count != 0)
            {
                (long val, int i) = pq.Dequeue();
                m.Add(i, rep);
                if (rem > 0)
                {
                    m[i]++;
                    rem--;
                }
            }

            for (int i = 0;i<n; i++)
            {
                long pw = PowerOf(multiplier, m[i], mod);
                nums[i] = (int)(((temp[i] % mod) * (pw % mod)) % mod);
            }

            return nums;
        }
        private long PowerOf(long a, int b, long mod)
        {

            long ans = 1;
            while (b > 0)
            {
                if (b % 2 == 1)
                    ans = (ans * a)%mod;
                a = (a * a) % mod;
                b = b / 2;
            }
            return ans;
        }
    }
}
