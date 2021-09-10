using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GFG
{
    public class CountInversion
    {
        public static (long, string) InversionCount(long[] arr, long N)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            var ss = Sorter(arr, new long[N], 0, N - 1, 0, map);
            string xcxc = "";
            foreach (var key in map.Keys)
            {
                xcxc = xcxc + key +" :: " + map[key];
                xcxc += Environment.NewLine;
            }
            return (ss, xcxc);

        }



        private static long Sorter(long[] arr, long[] aux, long lo, long hi, int x,
            Dictionary<string, string> dictionary)
        {
            var z = Print(x, lo, hi);

            dictionary.Add(z,"");
            if (lo >= hi)
            {
                if (dictionary.ContainsKey(z))
                    dictionary[z] = "--> s1: " + 0 + ", s2: " + 0 + ", m: " + 0 + "; ans =" + (0);
                else
                {
                    throw new NoNullAllowedException();
                }
                return 0;
            }
            long mid = lo + (hi - lo) / 2;

            var s1 = Sorter(arr, aux, lo, mid, x + 1, dictionary);
            var s2 = Sorter(arr, aux, mid + 1, hi, x + 1, dictionary);
            if (lo == 0 && hi == 2)
            {

            }
            var m = Merge(arr, aux, lo, mid, hi);
            if (dictionary.ContainsKey(z))
                dictionary[z] = "--> s1: " + s1 + ", s2: " + s2 + ", m: " + m + "; ans =" + (s1 + s2 + m);
            else
                dictionary.Add(z, "--> s1: " + s1 + ", s2: " + s2 + ", m: " + m + "; ans =" + (s1 + s2 + m));
            return s1 + s2 + m;


        }

        private static long Merge(long[] arr, long[] aux, long lo, long mid, long hi)
        {
            for (long k = lo; k <= hi; k++)
            {
                aux[k] = arr[k];
            }
            long i = lo;
            long j = mid + 1;
            long ans = 0;
            for (long k = lo; k <= hi; k++)
            {
                if (i > mid)
                {
                    arr[k] = aux[j++];
                    continue;
                }
                if (j > hi)
                {
                    arr[k] = aux[i++];
                    continue;
                }
                if (aux[i] <= aux[j])
                {
                    arr[k] = aux[i++];
                }
                else
                {
                    ans += mid - i+1;
                    arr[k] = aux[j++];
                }
            }
            return ans;
        }

        private static string Print(long x, long lo, long hi)
        {
            string xcxc = "";
            for (int i = 0; i < x; i++)
            {
                xcxc += "  ";
            }

            //xcxc = xcxc + "Sorter(lo:" + lo + " mid:" + mid + " hi:" + hi + ")";
            xcxc = xcxc + "Sorter(lo:" + lo + " hi:" + hi + ")";
            return xcxc;



        }
    }
}
