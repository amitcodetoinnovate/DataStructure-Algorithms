using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class SetMatrixZeroes
    {
        public static void  SetZeroes(int[][] matrix)
        {
            bool isRow = false;
            int R = matrix.Length;
            int C = matrix[0].Length;

            for (int i = 0; i < R; i++)
            {
                if (matrix[i][0] == 0)
                    matrix[0][0] = 0;
                for (int j = 1; j < C; j++)
                {
                    if (i == 0 && matrix[i][j] == 0)
                        isRow = true;
                    else if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                    }
                    if (matrix[i][j] == 0)
                    {
                        matrix[0][j] = 0;
                    }

                }
            }
            for (int i = 1; i < R; i++)
            {
                for (int j = 1; j < C; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                        matrix[i][j] = 0;
                }
            }
            if (matrix[0][0] == 0)
            {
                for (int i = 0; i < R; i++)
                {
                    matrix[i][0] = 0;
                }
            }

            if (isRow)
            {
                for (int i = 0; i < C; i++)
                {
                    matrix[0][i] = 0;
                }
            }
        }
    }
}
