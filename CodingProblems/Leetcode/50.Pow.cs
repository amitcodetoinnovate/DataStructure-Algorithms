//https://leetcode.com/problems/powx-n/
namespace CodingProblems.Leetcode
{
    public class Power
    {
        public static double MyPow(double x, int n)
        {
            int pow = n;
            double ans = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ans = ans * x;
                x = x * x;
                pow >>= 1;
            }
            return n < 0 ? 1 / ans : ans;
        }

        public double MyPowRecursive(double x, int n)
        {
            double ans = Helper(x, n);
            return n < 0 ? 1 / ans : ans;
        }

        private double Helper(double x, int n)
        {
            if (n == 0) return 1;
            double ans = Helper(x, n / 2);
            if (n % 2 == 0)
                return ans * ans;
            return ans * ans * x;
        }

    }
}
