namespace playground;

public class ClearStars3170
{
    /// <summary>
    /// https://leetcode.com/problems/lexicographically-minimum-string-after-removing-stars
    /// </summary>
    public static string ClearStars(string s)
    {
        var chs = new char[s.Length];
        var indexes = new List<int>[26];
        for (int i = 0; i < 26; i++) indexes[i] = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                var list = indexes.First(l => l.Count > 0);
                chs[list[^1]] = default;
                list.RemoveAt(list.Count - 1);
            }
            else
            {
                chs[i] = s[i];
                indexes[s[i] - 'a'].Add(i);
            }
        }
        return new string(chs.Where(x => x != default).ToArray());
    }
}
