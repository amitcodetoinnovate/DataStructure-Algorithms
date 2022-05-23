//https://leetcode.com/problems/valid-parentheses/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Leetcode
{
    public class ValidParentheses
    {
        public static bool Solve(string s)
        {
            Dictionary<char, char> op = new Dictionary<char, char>();
            op.Add('(', ')');
            op.Add('[', ']');
            op.Add('{', '}');

            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (op.ContainsKey(c))
                {
                    st.Push(op[c]);
                }
                else
                {
                    if (st.Count == 0 || st.Pop() != c)
                        return false;
                }
            }
            return st.Count == 0;


        }
    }
}
