using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GFG
{
    public class ThreeWayPartitioning
    {
        public void ThreeWayPartitionSolve(int[] arr, int a, int b)
        {
            int start = 0;
            int end = arr.Length - 1;
            for (int i = 0; i <= end;)
            {
                if (arr[i] < a)
                {
                    Swap(arr, start, i);
                    i++;
                    start++;
                }
                else if (arr[i] > b)
                {
                    Swap(arr, end, i);
                    end--;
                }
                else
                {
                    i++;
                }
            }


        }
        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
