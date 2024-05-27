namespace playground;

public class Partition0131
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-partitioning
    /// </summary>
    public static IList<IList<string>> Partition(string s)
    {
        var res = new List<IList<string>>();
        Bt(s, new List<string>(), res);
        return res;
    }

    static void Bt(string s, List<string> step, List<IList<string>> res)
    {
        if (s.Length == 0)
        {
            res.Add(new List<string>(step));
            return;
        }
        for (int len = 1; len <= s.Length; len++)
        {
            var temp = s[..len];
            if (!IsPalindrome(temp))
                continue;

            step.Add(temp);
            Bt(s[len..], step, res);
            step.RemoveAt(step.Count - 1);
        }
    }

    static bool IsPalindrome(string s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            if (s[l++] != s[r--])
                return false;
        }
        return true;
    }
}
