namespace playground;

public class FindPermutationDifference3146
{
    /// <summary>
    /// https://leetcode.com/problems/permutation-difference-between-two-strings
    /// </summary>
    public static int FindPermutationDifference(string s, string t)
    {
        int[] chs1 = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            chs1[s[i] - 'a'] = i;
        }
        int res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            res += Math.Abs(chs1[t[i] - 'a'] - i);
        }
        return res;
    }
}
