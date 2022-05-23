using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.RandomProblems
{
    public class ExcelColumnPrint
    {
        private static int M = 0;
        public static void PrintColums(int n)
        {
            M = n;
            PrintAToZ(GetAlphabetArray(), "");
            PrintHelper(GetAlphabetArray(), "", 1,true);
        }
       
        private static void PrintHelper(char[] arr, string prefix, int counter,bool IsMainCall)
        {
            if (counter == 0)
            {
                PrintAToZ(arr, prefix);
            }
            else
            {
                for (int i = 0; i < 26 && M>0; i++)
                {
                    PrintHelper(arr, prefix + arr[i], counter - 1,false);
                }
                if (IsMainCall && M>0)
                {
                    PrintHelper(arr, "", counter + 1, true);
                }
            }

        }

        private static void PrintAToZ(char[] arr, string prefix)
        {
            for (int i = 0; i < arr.Length && M>0; i++,M--)
            {

                System.Diagnostics.Debug.Write(prefix + arr[i] +" | ");
            }
        }

        private static char[] GetAlphabetArray()
        {
            char[] arr = new char[26];
            arr[0] = 'A';
            int a = 5;
            a *= 2;
            for (int i = 0; i < 26; i++)
            {
                arr[i] = (char)(arr[0] + (char)i);
            }
            return arr;
        }
    }
}
