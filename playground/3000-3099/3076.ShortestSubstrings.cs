namespace playground;

public class ShortestSubstrings3076
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-uncommon-substring-in-an-array
    /// </summary>
    public static string[] ShortestSubstrings(string[] arr)
    {
        var d = new Dictionary<string, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            Add(arr[i], d);
        }
        var res = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            Minus(arr[i], d);
            res[i] = string.Empty;
            for (int j = 0; j < arr[i].Length; j++)
            {
                for (int k = j; k < arr[i].Length; k++)
                {
                    var s = arr[i].Substring(j, k - j + 1);
                    if (d[s] > 0) continue;
                    if (res[i] == string.Empty || (s.CompareTo(res[i]) < 0 && s.Length == res[i].Length) || s.Length < res[i].Length)
                    {
                        res[i] = s;
                    }
                }
            }
            Add(arr[i], d);
        }
        return res;
    }

    static void Add(string str, Dictionary<string, int> d)
    {
        for (int j = 0; j < str.Length; j++)
        {
            for (int k = j; k < str.Length; k++)
            {
                var s = str.Substring(j, k - j + 1);
                d[s] = d.ContainsKey(s) ? d[s] + 1 : 1;
            }
        }
    }

    static void Minus(string str, Dictionary<string, int> d)
    {
        for (int j = 0; j < str.Length; j++)
        {
            for (int k = j; k < str.Length; k++)
            {
                var s = str.Substring(j, k - j + 1);
                d[s]--;
            }
        }
    }
}
