using System;
using System.Collections.Generic;
// https://leetcode.com/problems/reveal-cards-in-increasing-order/

namespace Algorithms.Leetcode
{
    public class RevealCardsInIncreasingOrder
    {
        public static int[] Solve(int[] deck)
        {
            Queue<int> q = new Queue<int>();
            Array.Sort(deck);
            int j = deck.Length - 1;
            q.Enqueue(deck[j--]);
            while (j > -1)
            {
                q.Enqueue(q.Dequeue());
                q.Enqueue(deck[j--]);
            }

            for (int i = deck.Length - 1; i > -1; i--)
                deck[i] = q.Dequeue();
            return deck;

        }
    }
}
