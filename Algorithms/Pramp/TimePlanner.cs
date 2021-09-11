using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Pramp
{
    public class TimePlanner
    {
        public static int[] MeetingPlanner(int[,] slotsA, int[,] slotsB, int dur)
        {
            int i = 0;
            int j = 0;
            int A = slotsA.GetLength(0);
            int B = slotsB.GetLength(1);
            while (i >= A || j >= B)
            {
                int a1 = slotsA[i, 0];
                int a2 = slotsA[i, 1];
                int b1 = slotsB[j, 0];
                int b2 = slotsB[j, 1];
                int start = Math.Max(a1, b1);
                int end = Math.Min(a2, b2);
                if (end - start >= dur)
                    return new int[] { start, start + dur };

                if (a2 > b2)
                    j++;
                else
                    i++;
            }

            return Array.Empty<int>();
        }

    }
}
