using System;

namespace AlgorithmsPartI
{
    public class MinPQ<T> where T : IComparable<T> //class for custom comparer function
    {
        private T[] _pq;
        private int _n;

        public MinPQ(int capacity)
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

        public T DeleteMin()
        {
            T min = _pq[1];
            Exchange(1, _n--);
            Sink(1);
            return min;
            //_pq[_n + 1] = null;
        }

        public T Min()
        {
            return _pq[1];
        }
        private void Swim(int k)
        {
            while (k > 1 && Greater(k / 2, k))
            {
                Exchange(k, k / 2);
                k = k / 2;
            }
        }

        private bool Greater(int i, int j)
        {
            return _pq[i].CompareTo(_pq[j]) > 0;
        }

        private void Exchange(int i, int j)
        {
            (_pq[i], _pq[j]) = (_pq[j], _pq[i]);
        }

        private void Sink(int k)
        {
            while (2 * k <= _n)
            {
                int j = 2 * k;
                if (j < _n && Greater(j, j + 1))
                    j++;
                if (!Greater(k, j))
                    break;
                Exchange(k, j);
                k = j;
            }
        }

    }
}
