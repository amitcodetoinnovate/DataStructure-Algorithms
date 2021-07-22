using System;
using System.Collections;
using AlgorithmsPartI;
using Microsoft.VisualBasic.CompilerServices;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.PriorityQueues
{
    public class PriorityQueueHeapTest
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [InlineData(new int[] { 2, 8, 1, 3, 6, 7, 5, 4 }, 8)]
        [InlineData(new int[] { 10, 14, 28, 11, 7, 16, 30, 50, 25, 18 }, 50)]
        public void MaxPriorityQueue_Test(int[] nums, int ans)
        {
            MaxPQ<int> pq = new MaxPQ<int>(nums.Length);
            foreach (int num in nums)
            {
                pq.Insert(num);
            }
            Assert.Equal(pq.Max(), ans);
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 1)]
        [InlineData(new int[] { 2, 8, 1, 3, 6, 7, 5, 4 }, 1)]
        [InlineData(new int[] { 10, 14, 28, 11, 7, 16, 30, 50, 25, 18 }, 7)]
        public void MinPriorityQueue_Test(int[] nums, int ans)
        {
            MinPQ<int> pq = new MinPQ<int>(nums.Length);
            foreach (int num in nums)
            {
                pq.Insert(num);
            }
            Assert.Equal(pq.Min(), ans);
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 })]
        [InlineData(new int[] { 2, 8, 1, 3, 6, 7, 5, 4 })]
        [InlineData(new int[] { 10, 14, 28, 11, 7, 16, 30, 50, 25, 18 })]
        public void HeapSort_Test(int[] nums)
        {
            var output = (int[])nums.Clone();
            Array.Sort(output);
            HeapSort.Sort(nums);
            
            Assert.Equal(nums, output);
        }
    }
}
