//https://leetcode.com/problems/integer-to-english-words/
using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public class IntegerToEnglishWords
    {
        public static string Solve(int num)
        {
            if (num == 0)
                return "Zero";
            Dictionary<int, string> map = new Dictionary<int, string>();
            map.Add(0, "");
            map.Add(1, "One");
            map.Add(2, "Two");
            map.Add(3, "Three");
            map.Add(4, "Four");
            map.Add(5, "Five");
            map.Add(6, "Six");
            map.Add(7, "Seven");
            map.Add(8, "Eight");
            map.Add(9, "Nine");
            map.Add(10, "Ten");
            map.Add(11, "Eleven");
            map.Add(12, "Twelve");
            map.Add(13, "Thirteen");
            map.Add(14, "Fourteen");
            map.Add(15, "Fifteen");
            map.Add(16, "Sixteen");
            map.Add(17, "Seventeen");
            map.Add(18, "Eighteen");
            map.Add(19, "Nineteen");
            map.Add(20, "Twenty");
            map.Add(30, "Thirty");
            map.Add(40, "Forty");
            map.Add(50, "Fifty");
            map.Add(60, "Sixty");
            map.Add(70, "Seventy");
            map.Add(80, "Eighty");
            map.Add(90, "Ninety");
            return FindNum(num, map);
        }

        public static string FindNum(int n, Dictionary<int, string> map)
        {
            if (n < 10)
                return map[n];
            if (n > 9 && n < 100)
            {
                if (n <= 20)
                    return map[n];
                return map[(n / 10) * 10] + (n % 10 == 0 ? "" : " ") + FindNum(n % 10, map);
            }
            if (n > 99 && n < 1000)
                return map[(n / 100)] + " Hundred" + (n % 100 == 0 ? "" : " ") + FindNum(n % 100, map);
            if (n > 999 && n < 1000000)
                return FindNum(n / 1000, map) + " Thousand" + (n % 1000 == 0 ? "" : " ") + FindNum(n % 1000, map);
            if (n > 999999 && n < 1000000000)
                return FindNum(n / 1000000, map) + " Million" + (n % 1000000 == 0 ? "" : " ") + FindNum(n % 1000000, map);
            return FindNum(n / 1000000000, map) + " Billion" + (n % 1000000000 == 0 ? "" : " ") + FindNum(n % 1000000000, map);
        }
    }
}
