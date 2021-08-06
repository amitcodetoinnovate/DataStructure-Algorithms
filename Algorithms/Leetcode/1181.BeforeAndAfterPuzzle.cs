//https://leetcode.com/problems/before-and-after-puzzle/
using System.Collections.Generic;

public class BeforeAndAfterPuzzles
{
    public static IList<string> Solve(string[] phrases)
    {
        List<string> res = new List<string>();
        Dictionary<string, int> z = new Dictionary<string, int>();
        IList<string[]> map = new List<string[]>();
        for (int i = 0; i < phrases.Length; i++)
        {
            map.Add(phrases[i].Split(null));
        }

        for (int i = 0; i < phrases.Length - 1; i++)
        {
            for (int j = i + 1; j < phrases.Length; j++)
            {
                if (map[i][map[i].Length - 1].Equals(map[j][0]))
                {
                    int k = phrases[i].LastIndexOf(' ');
                    string a = phrases[i].Substring(0, k == -1 ? 0 : k);
                    if (k != -1)
                        a = a + ' ';
                    string o = a + phrases[j];
                    if (!z.ContainsKey(o))
                    {
                        z.Add(o, 1);
                        res.Add(o);
                    }

                }
            }
        }
        for (int i = 0; i < phrases.Length - 1; i++)
        {
            for (int j = i + 1; j < phrases.Length; j++)
            {
                if (map[i][0].Equals(map[j][map[j].Length - 1]))
                {
                    int k = phrases[j].LastIndexOf(' ');
                    string a = phrases[j].Substring(0, k == -1 ? 0 : k);
                    if (k != -1)
                        a = a + ' ';
                    string o = a + phrases[i];
                    if (!z.ContainsKey(o))
                    {
                        z.Add(o, 1);
                        res.Add(o);
                    }

                }
            }
        }
        res.Sort();
        return res;
    }

    private static void MergeSort(IList<string> arr, string[] aux, int lo, int hi)
    {
        if (hi <= lo)
            return;
        int mid = lo + (hi - lo) / 2;
        MergeSort(arr, aux, lo, mid);
        MergeSort(arr, aux, mid + 1, hi);
        Merge(arr, aux, lo, mid, hi);
    }

    private static void Merge(IList<string> arr, string[] aux, int lo, int mid, int hi)
    {
        for (int k = lo; k <= hi; k++)
            aux[k] = arr[k];
        int i = lo, j = mid + 1;
        for (int k = lo; k <= hi; k++)
        {
            if (i <= mid && j <= hi)
            {
                int c = aux[i].CompareTo(aux[j]);
                if (c < 0)
                    arr[k] = aux[i++];
                else
                    arr[k] = aux[j++];

            }
            else if (i <= mid)
            {
                arr[k] = aux[i++];
            }
            else
            {
                arr[k] = aux[j++];
            }
        }
    }
}
