//https://leetcode.com/problems/sort-colors/
namespace CodingProblems.Leetcode
{
    public class SortColors
    {
        public static void DutchNationalFlagProblem(int[] arr)
        {
            int onePointer = 0;
            int unknownStart = 0;
            int unknownEnd = arr.Length - 1;
            while (unknownStart <= unknownEnd)
            {
                if (arr[unknownStart] == 0)
                {
                    Swap(arr, onePointer, unknownStart);
                    unknownStart++;
                    onePointer++;
                }
                else if (arr[unknownStart] == 1)
                { 
                    unknownStart++;
                }
                else
                {
                    Swap(arr, unknownStart, unknownEnd);
                    unknownEnd--;
                }
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
