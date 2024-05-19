namespace playground;

public class MaxLengthBetweenEqualCharacters1624
{
    /// <summary>
    /// https://leetcode.com/problems/largest-substring-between-two-equal-characters
    /// </summary>
    public static int MaxLengthBetweenEqualCharacters(string s)
    {
        var memo = Enumerable.Repeat(-1, 26).ToArray();
        var res = int.MinValue;
        for (int i = 0; i < s.Length; i++)
        {
            if (memo[s[i] - 'a'] == -1)
                memo[s[i] - 'a'] = i;
            else
                res = Math.Max(res, i - memo[s[i] - 'a'] - 1);
        }
        return res == int.MinValue ? -1 : res;
    }
}
