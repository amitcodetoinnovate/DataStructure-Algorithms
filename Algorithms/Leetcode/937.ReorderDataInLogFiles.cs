//https://leetcode.com/problems/reorder-data-in-log-files/
using System;

namespace Algorithms.Leetcode
{
    public class ReorderDataInLogFiles
    {
        public static string[] Solve(string[] logs)
        {
            string[] ans = new string[logs.Length];
            string[] aux = new string[logs.Length];

            for (int i = 0; i < logs.Length; i++)
            {
                ans[i] = logs[i];
            }
            MergeSort(ans, aux, 0, ans.Length - 1);
            return ans;
        }

        private static void MergeSort(string[] arr, string[] aux, int lo, int hi)
        {
            if (hi <= lo)
                return;
            int mid = lo + (hi - lo) / 2;
            MergeSort(arr, aux, lo, mid);
            MergeSort(arr, aux, mid + 1, hi);
            Merge(arr, aux, lo, mid, hi);
        }

        private static void Merge(string[] arr, string[] aux, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = arr[k];
            }

            int i = lo;
            int j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                    arr[k] = aux[j++];
                else if (j > hi)
                    arr[k] = aux[i++];
                else if (IsLess(aux[i], aux[j]))
                    arr[k] = aux[i++];
                else
                    arr[k] = aux[j++];
            }
        }

        private static bool IsLess(string i, string j)
        {
            bool iIs = !Char.IsDigit(i[i.LastIndexOf(' ') + 1]);
            bool jIs = !Char.IsDigit(j[j.LastIndexOf(' ') + 1]);
            if (iIs && jIs)
            {
                string[] iS = i.Split(' ');
                string[] jS = j.Split(' ');
                int k = 1;
                for (; k < Math.Min(iS.Length, jS.Length); k++)
                {
                    int c = string.Compare(iS[k], jS[k]);
                    if (c == 0)
                        continue;
                    else
                        return c < 0;
                }
                if (jS.Length == k && iS.Length == k)
                {
                    int m = string.Compare(iS[0], jS[0]);
                    return m < 0;

                }
                if (k < jS.Length)
                    return true;
                return false;

            }
            else if (!iIs && !jIs)
                return true;
            else if (iIs && !jIs)
                return true;
            return false;
        }

    }
}
