namespace playground;

public class _3211_ValidStrings
{
    /// <summary>
    /// https://leetcode.com/problems/generate-binary-strings-without-adjacent-zeros
    /// </summary>
    public static IList<string> ValidStrings(int n)
    {
        var res = new List<string>();
        Dfs(n, new List<char>(), res);
        return res;
    }

    public static void Dfs(int n, List<char> chs, List<string> res)
    {
        if (chs.Count == n)
        {
            res.Add(new string(chs.ToArray()));
            return;
        }
        if (chs.Count == 0)
        {
            chs.Add('0');
            Dfs(n, chs, res);
            chs[0] = '1';
            Dfs(n, chs, res);
        }
        else
        {
            if (chs[^1] == '0')
            {
                chs.Add('1');
                Dfs(n, chs, res);
            }
            else
            {
                chs.Add('0');
                Dfs(n, chs, res);
                chs[^1] = '1';
                Dfs(n, chs, res);
            }
        }

        chs.RemoveAt(chs.Count - 1);
    }
}
