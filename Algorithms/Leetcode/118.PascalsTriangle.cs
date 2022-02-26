using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                res.Add(new List<int> { 1 });
                for (int j = 1; j <= i; j++)
                    res[i].Add(res[i - 1][j - 1] + (j != i ? res[i - 1][j] : 0));
            }
            return res;
        }

    }
}
