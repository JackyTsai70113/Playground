namespace playground.LeetCode._3000_3999;

public class _3324_StringSequence
{
    public static IList<string> StringSequence(string target)
    {
        var res = new List<string> { "a" };
        var cur = new List<char> { 'a' };
        while (new string(cur.ToArray()) != target)
        {
            if (cur[^1] != target[cur.Count - 1])
            {
                cur[^1] = (char)(cur[^1] + 1);
            }
            else
            {
                cur.Add('a');
            }
            res.Add(new string(cur.ToArray()));
        }
        return res;
    }
}
