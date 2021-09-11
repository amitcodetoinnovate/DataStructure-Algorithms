using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GFG
{
    public class NMeetingsInOneRoom
    {
        public static int MaxMeetings(int[] start, int[] end, int n)
        {

            List<int[]> met = new List<int[]>();
            for (int i = 0; i < n; i++)
                met.Add(new int[] { start[i], end[i] });
            met.Sort((a, b) => a[0].CompareTo(b[0]) == 0 ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));
            int count = 1;
            for (int i = 0; i < n - 1; i++)
                if (met[i][1] < met[i + 1][0])
                    count++;
            return count;
        }
    }
}
