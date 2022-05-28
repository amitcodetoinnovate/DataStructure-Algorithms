using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
/// <summary>
///https://leetcode.com/problems/escape-the-spreading-fire/
///#Hard
/// </summary>
namespace CodingProblems.Leetcode
{
    public class EscapetheSpreadingFire
    {
        public int MaximumMinutes(int[][] grid)
        {
            int[,] minTimeToReachFire = InitializeDistanceMatrix(grid);
            Queue<(int x, int y, int d)> queue = GetBFSQueueAndSetInitialTimeOfFire(grid, minTimeToReachFire);
            FillMinimumTimeToReachFireToEachCell(minTimeToReachFire, queue, grid);
            return GetAnswerByBinarySearch(grid,minTimeToReachFire);
        }

        private int GetAnswerByBinarySearch(int[][] grid, int[,] minTimeToReachFire)
        {
            int left = 0;
            int right = 1_000_000_000;

            int ans = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (IsPathExist(grid, minTimeToReachFire, mid))
                {
                    ans = mid;
                    left = mid+1;
                }else
                    right = mid-1;
            }
            return ans;
        }

        private bool IsPathExist(int[][] grid, int[,] minTimeToReachFire, int waitTime)
        {
            int n = minTimeToReachFire.GetLength(0);
            int m = minTimeToReachFire.GetLength(1);
            (int x, int y)[] directions = GetDirectionsArray();
            bool[,] isVisited = new bool[n, m];
            
            Queue<(int x, int y, int d)> queue = new Queue<(int x, int y, int d)>();
            queue.Enqueue((0, 0, waitTime));
            isVisited[0, 0] = true;
            while (queue.Count!=0)
            {
                var location = queue.Dequeue();
                foreach (var direction in directions)
                {
                    int newX = location.x + direction.x;
                    int newY = location.y + direction.y;
                    if (!IsValidCoOrdinate(newX, newY, n, m) || isVisited[newX, newY] || grid[newX][newY] == 2)
                        continue;
                    if (newX == n - 1 && newY == m - 1 && minTimeToReachFire[newX, newY] >= location.d + 1)
                        return true;
                    if (minTimeToReachFire[newX, newY] <= location.d + 1)
                        continue;
                    queue.Enqueue((newX, newY, location.d + 1));
                    isVisited[newX,newY] = true;
                }
            }
            return false;
        }



        private void FillMinimumTimeToReachFireToEachCell(int[,] minTimeToReachFire, Queue<(int x, int y, int d)> queue, int[][] grid)
        {
            bool[,] isVisited = new bool[minTimeToReachFire.GetLength(0), minTimeToReachFire.GetLength(1)];
            (int x, int y)[] directions = GetDirectionsArray();
            while (queue.Count != 0)
            {
                var fire = queue.Dequeue();
                foreach (var direction in directions)
                {
                    var newX = fire.x + direction.x;
                    var newY = fire.y + direction.y;
                    if (IsValidCoOrdinate(newX, newY, minTimeToReachFire.GetLength(0), minTimeToReachFire.GetLength(1))
                        && !isVisited[newX, newY]
                        && grid[newX][newY] != 2
                        && minTimeToReachFire[newX, newY] > (minTimeToReachFire[fire.x, fire.y] + 1))
                    {
                        minTimeToReachFire[newX, newY] = minTimeToReachFire[fire.x, fire.y] + 1;
                        queue.Enqueue((newX,newY, minTimeToReachFire[newX, newY]));
                        isVisited[newX, newY] = true;
                    }

                }
            }
        }

        private bool IsValidCoOrdinate(int newX, int newY, int m, int n)
        {
            return newX > -1 && newX < m && newY < n && newY > -1;
        }

        private (int x, int y)[] GetDirectionsArray()
        {
            return new (int x, int y)[] { (-1, 0), (1, 0), (0, 1), (0, -1) };
        }

        private Queue<(int x, int y, int d)> GetBFSQueueAndSetInitialTimeOfFire(int[][] grid, int[,] ans)
        {
            Queue<(int x, int y, int d)> queue = new Queue<(int, int, int)>();
            for (int i = -0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        queue.Enqueue((i, j, 0));
                        ans[i, j] = 0;
                    }
                }
            }
            return queue;
        }

        private int[,] InitializeDistanceMatrix(int[][] grid)
        {
            int[,] ans = new int[grid.Length, grid[0].Length];
            for (int i = 0; i < ans.GetLength(0); i++)
                for (int j = 0; j < ans.GetLength(1); j++)
                    ans[i, j] = int.MaxValue;
            return ans;
        }
    }
}
