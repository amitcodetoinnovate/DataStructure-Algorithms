using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class NumberofIslands
    {
        public static int NumIslands(char[][] grid)
        {
            int c = 0;
            int m = grid.Length;
            int n = grid[0].Length;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        BFS(grid, i, j, m, n);
                        c++;
                    }
                }
            }
            return c;
        }

        private static void BFS(char[][] grid, int i, int j, int m, int n)
        {
            grid[i][j] = 'c';
            //Go up
            if (i - 1 >= 0 && grid[i - 1][j] == '1')
                BFS(grid, i - 1, j, m, n);
            //Go down
            if (i + 1 < m && grid[i + 1][j] == '1')
                BFS(grid, i + 1, j, m, n);
            //Go left
            if (j - 1 >= 0 && grid[i][j - 1] == '1')
                BFS(grid, i, j - 1, m, n);
            if (j + 1 < n && grid[i][j + 1] == '1')
                BFS(grid, i, j + 1, m, n);
        }

    }
}
