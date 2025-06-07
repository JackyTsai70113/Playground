using System.Text;

namespace playground.LeetCode._3000_3999;

public class _3170_ClearStars
{
    public static string ClearStars(string s)
    {
        var chs = new List<int>[26];
        for (int i = 0; i < 26; i++) chs[i] = new();
        int n = s.Length;
        var valid = new bool[n];
        int minCharIndex = 0;

        for (int i = 0; i < n; i++)
        {
            if (s[i] != '*')
            {
                minCharIndex = Math.Min(minCharIndex, s[i] - 'a');
                valid[i] = true;
                chs[s[i] - 'a'].Add(i);
            }
            else
            {
                while (minCharIndex < 26 && chs[minCharIndex].Count == 0)
                {
                    minCharIndex++;
                }
                if (minCharIndex < 26)
                {
                    int idx = chs[minCharIndex][^1];
                    valid[idx] = false;
                    chs[minCharIndex].RemoveAt(chs[minCharIndex].Count - 1);
                }
            }
        }
        var sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            if (valid[i])
                sb.Append(s[i]);
        }
        return sb.ToString();
    }
}
