namespace playground;

public class GenerateParenthesis0022
{
    /// <summary>
    /// https://leetcode.com/problems/generate-parentheses
    /// </summary>
    public static IList<string> GenerateParenthesis(int n)
    {
        var res = new List<string>();
        Bt(n, 0, 0, new List<char>(), res);
        return res;
    }

    static void Bt(int n, int left, int right, List<char> cur, List<string> res)
    {
        if (cur.Count == n * 2)
        {
            res.Add(new string(cur.ToArray()));
            return;
        }
        if (left < n)
        {
            cur.Add('(');
            Bt(n, left + 1, right, cur, res);
            cur.RemoveAt(cur.Count - 1);
        }
        if (right < left)
        {
            cur.Add(')');
            Bt(n, left, right + 1, cur, res);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}
