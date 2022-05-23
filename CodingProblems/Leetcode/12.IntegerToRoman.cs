//https://leetcode.com/problems/integer-to-roman
using System;

namespace CodingProblems.Leetcode
{
    public class IntegerToRoman
    {
        public static string Solve(int num)
        {
            int noOfDigits = GetNumberOfDigits(num);
            return IntegerToRomanHelper(num, noOfDigits);
        }

        public static string IntegerToRomanHelper(int num, int m)
        {
            if (num < 1)
                return "";
            int pow = (int)Math.Pow(10, m-1);
            int n = (num / (pow)) * pow;
            return GetRomanValuesForPlace(n, m-1) + IntegerToRomanHelper(num - n, m - 1);
        }

        public static int GetNumberOfDigits(int num)
        {
            int i = 0;
            for (; num>0; num /= 10,i++) {}
            return i;
        }

        public static string GetRomanValuesForPlace(int num, int pow)
        {
            if (pow == 0)
            {
                if (num == 9)
                    return "IX";
                if(num < 4)
                    return GetRomanStringForNumber("", "I", num, 0);
                return GetRomanStringForNumber("V", "I", num, 5);
            }

            if (pow == 1)
                return GetRomanBase("X", "L", "C", num, 1);
            if (pow == 2)
                return GetRomanBase("C", "D", "M", num, 10);
            return GetRomanStringForNumber("", "M", num / 1000, 0);

        }

        public static string GetRomanBase(string lowTen, string midTen, string hiTen, int num, int m)
        {
            if (num == 10 * m)
                return lowTen;
            if (num == 90 * m)
                return lowTen + hiTen;
            if (num < 40 * m)
                return GetRomanStringForNumber("", lowTen, num / (10 * m), 0);
            return GetRomanStringForNumber(midTen, lowTen, num / (10 * m), 5);
        }
        public static string GetRomanStringForNumber(string main, string aux, int num, int thresh)
        {
            string s = "";
            for (int c = Math.Abs(thresh - num); c > 0; c--)
                s = s + aux;
            return num > thresh ? main + s : s + main;
        }
    }
}
