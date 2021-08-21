using System;
using System.Linq;
using System.Security.Authentication;

namespace Playground
{
    public class RandomMinHeap
    {
        private int[] _minPQ;
        private int _n = 0;
        public RandomMinHeap(int capacity)
        {
            _minPQ = new int[capacity + 1];
        }

        public void Insert(int element)
        {
            _minPQ[++_n] = element;
            Swim(_n);
        }

        private void Swim(int k)
        {
            while (k>1 && IsGreater(k/2,k))
            {
                Exchange(k / 2, k);
                k /= 2;

            }
        }

        private void Exchange(int i, int j)
        {
            var x = _minPQ[i];
            _minPQ[i] = _minPQ[j];
            _minPQ[j] = x;
        }

        private bool IsGreater(int i, int j)
        {
            return _minPQ[i] > _minPQ[j];
        }
    }
}
