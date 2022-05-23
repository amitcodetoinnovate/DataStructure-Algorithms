using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Pramp
{
    public class ShiftedArraySearch
    {
        public static int Search(int[] nums, int target)
        {
            int[] A = nums;
            int k = target;
            int lo = 0, hi = nums.Length - 1;
            while (lo <= hi)
            {

                int m = lo + (hi - lo) / 2;
                if (A[m] == k) return m;
                if (A[lo] < A[m] && k < A[m])
                    hi = m - 1;
                else
                    lo = m + 1;
            }
            return -1;

        }

        private static int SearchShiftPoint(int[] shiftArr)
        {
            int lo = 0, hi = shiftArr.Length - 1; // 0 , 1
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2; //0
                if (mid > 0 && shiftArr[mid] < shiftArr[mid - 1])
                {
                    return mid;
                }
                if (shiftArr[lo] < shiftArr[hi])
                {
                    hi = mid - 1;
                }
                else
                {
                    lo = mid + 1;  // 1
                }
            }
            return lo;
        }

        private static int BinarySearch(int[] shiftArr, int lo, int hi, int num)
        {
            while (lo <= hi)
            {
                int mid = (lo + (hi - lo) / 2) % shiftArr.Length;
                if (shiftArr[mid] > num)
                {
                    hi = ((lo + (hi - lo) / 2)) - 1;
                }
                else if (shiftArr[mid] < num)
                {
                    lo = ((lo + (hi - lo) / 2)) + 1;
                }
                else
                {
                    return (lo + (hi - lo) / 2) % shiftArr.Length;
                }

            }
            return -1;
        }


        public static int ShiftedArrSearch(int[] shiftArr, int num)
        {
            int shiftPoint = SearchShiftPoint(shiftArr);
            Console.Write(shiftPoint);
            return BinarySearch(shiftArr, shiftPoint, shiftPoint + shiftArr.Length - 1, num);
        }
    }
}
