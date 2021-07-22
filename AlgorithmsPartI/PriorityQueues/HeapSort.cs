using System;

namespace AlgorithmsPartI
{
    public class HeapSort
    {
        public static void Sort<T>(T[] pq) where T : IComparable<T>
        {
            int n = pq.Length;
            int k;
            for (k = n / 2; k >= 1; k--)
            {
                Sink(pq, k, n);
            }

            k = n;
            while (k > 1)
            {
                Exch(pq, 1, k--);
                Sink(pq, 1, k);
            }
        }

        private static void Sink<T>(T[] pq, int k, int n) where T : IComparable<T>
        {
            while (2 * k <= n)
            {
                int j = 2 * k;
                if (j < n && Less(pq, j, j + 1)) j++;
                if (!Less(pq, k, j))
                    break;
                Exch(pq, k, j);
                k = j;
            }
        }

        private static bool Less<T>(T[] pq, int i, int j) where T : IComparable<T>
        {
            return pq[i - 1].CompareTo(pq[j - 1]) < 0;
        }

        private static void Exch<T>(T[] pq, int i, int j) where T : IComparable<T>
        {
            T swap = pq[i - 1];
            pq[i - 1] = pq[j - 1];
            pq[j - 1] = swap;
        }
    }
}
