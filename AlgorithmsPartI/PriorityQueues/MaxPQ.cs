using System;
using System.Collections.Generic;

namespace AlgorithmsPartI
{
    public class MaxPQ<T> where T : IComparable<T>
    {
        private readonly T[] _pq;
        private int _n;

        public MaxPQ(int capacity)
        {
            _pq = new T[capacity + 1];
        }

        public Boolean IsEmpty()
        {
            return _n == 0;
        }

        public void Insert(T x)
        {
            _pq[++_n] = x;
            Swim(_n);
        }

        public void DeleteMax()
        {
            T max = _pq[1];
            Exchange(1, _n--);
            Sink(1);
        }

        public T Max()
        {
            return _pq[1];
        }
        private void Swim(int k)
        {
            while (k > 1 && Less(k / 2, k))
            {
                Exchange(k, k / 2);
                k = k / 2;
            }
        }

        private bool Less(int i, int j)
        {
            return _pq[i].CompareTo(_pq[j]) < 0;
        }

        private void Exchange(int i, int j)
        {
            T swap = _pq[i];
            _pq[i] = _pq[j];
            _pq[j] = swap;
        }

        private void Sink(int k)
        {
            while (2 * k <= _n)
            {
                int j = 2 * k;
                if (j < _n && Less(j, j + 1))
                    j++;
                if (!Less(k, j))
                    break;
                Exchange(k, j);
                k = j;
            }
        }

    }
}
