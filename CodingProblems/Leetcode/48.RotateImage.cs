//https://leetcode.com/problems/rotate-image/
namespace CodingProblems.Leetcode
{
    public class RotateImage
    {
        public static void RotateImageMatrix(int[][] matrix)
        {
            int n = matrix.GetLength(0);
            int cycles = n / 2;
            for (int i = 0; i < cycles; i++)
            {
                int bound = n - i - 1;
                for (int j = i; j < bound; j++)
                {
                    int topRightValue = matrix[j][n - i - 1];
                    matrix[j][n - i - 1] = matrix[i][j];

                    int bottomRightValue = matrix[n - i - 1][n - j - 1];
                    matrix[n - i - 1][n - j - 1] = topRightValue;

                    int bottomLeftValue = matrix[n - j - 1][i];
                    matrix[n - j - 1][i] = bottomRightValue;
                    
                    matrix[i][j] = bottomLeftValue;
                }
            }
        }
    }
}
