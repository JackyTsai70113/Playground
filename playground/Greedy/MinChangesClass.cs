namespace playground.Greedy;

public class MinChangesClass
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-changes-to-make-binary-string-beautiful
    /// </summary>
    public static int MinChanges(string s)
    {
        var res = 0;
        for (int i = 1; i < s.Length; i += 2)
        {
            if (s[i] != s[i - 1])
                res++;
        }
        return res;
    }
}
