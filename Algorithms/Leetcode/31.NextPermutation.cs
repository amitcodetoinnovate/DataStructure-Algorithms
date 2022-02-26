using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Leetcode
{
    public class NextPermutation
    {
        public static void NextPermute(char[] nums)
        {
            IList<char> list = new List<char>(nums);
            IList<IList<char>> res = new List<IList<char>>();
            GeneratePermutations(list, res, new List<char>());
            Prchar(res);
        }

        private static void GeneratePermutations(IList<char> input, IList<IList<char>> res, IList<char> output)
        {
            if (input.Count==0)
            {
                res.Add(new List<char>(output));
                return;
            }

            for(int i = 0; i < input.Count; i++)
            {
                char temp = input[i];
                output.Add(input[i]);
                input.RemoveAt(i);
                GeneratePermutations(input, res, output);
                input.Insert(i,temp);
                output.RemoveAt(output.Count - 1);
            }

        }

        private static void Prchar(IList<IList<char>> res)
        {
            foreach (var list in res)
            {
                foreach(char i in list)
                {
                    //System.Diagnostics.Debug.Write(i+" ");
                    Console.Write(i+" ");
                }
                //System.Diagnostics.Debug.WriteLine("");
                Console.WriteLine("");
            }
            
        }
    }
}
