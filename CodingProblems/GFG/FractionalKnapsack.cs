using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodingProblems.GFG
{
    public class FractionalKnapsack
    {
        public static double KnapSack(int W, Item[] arr, int n)
        {
            Array.Sort(arr, (a,b)=>((double)b.value/b.weight).CompareTo((double)b.value / b.weight));
            int i = 0;
            double ans = 0;
            while (i < n)
            {
                if(W==0)
                    break;

                if (arr[i].weight <= W)
                {
                    ans = ans + (double)arr[i].value;
                    W = W - arr[i].weight;
                }
                else
                {
                    double itemPricePerUnit = (double)arr[i].value / arr[i].weight;
                    ans += W * itemPricePerUnit;
                    W = 0;
                }

                i++;
            }

            return ans;
        }
    }
}
