using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace Algorithms.GFG
{
    public class JobSequencingProblem
    {
        public static int[] JobScheduling(Job[] arr, int n)
        {
            Array.Sort(arr,(a,b)=>b.profit.CompareTo(a.profit)==0?b.deadline.CompareTo(a.deadline): b.profit.CompareTo(a.profit));
            int max = 0;
            foreach (Job job in arr)
            {
                max = Math.Max(max, job.deadline);
            }

            int[] timeLine = new int [max+1];
            int profit = 0;
            int count = 0;
            for (int i = 1; i <= max; i++)
                timeLine[i] = -1;
            for (int i = 0; i < n; i++)
            {

                for (int j = arr[i].deadline; j > 0; j--)
                {
                    if (timeLine[j] == -1)
                    {
                        count++;
                        profit = profit + arr[i].profit;
                        timeLine[j] = i;
                        break;
                    }
                }
            }

            return new[] { count, profit };

        }
    }

    
}
