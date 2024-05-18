namespace playground;

public class MinimumSubstringsInPartition3144
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-substring-partition-of-equal-character-frequency
    /// </summary>
    public static int MinimumSubstringsInPartition(string s)
    {
        int res = s.Length;
        var memo = new int[s.Length];
        int dfs(int start)
        {
            if (start == s.Length) return 0;
            if (memo[start] != 0) return memo[start];
            memo[start] = int.MaxValue;
            var chs = new int[26];
            for (int i = start; i < s.Length; i++)
            {
                chs[s[i] - 'a']++;
                bool valid = true;
                int cur = 0;
                for (int j = 0; j < 26; j++)
                {
                    if (chs[j] != 0)
                    {
                        if (cur == 0)
                        {
                            cur = chs[j];
                        }
                        else if (cur != chs[j])
                        {
                            valid = false;
                            break;
                        }
                    }
                }
                if (valid)
                {
                    int dd = dfs(i + 1);
                    if (dd != int.MaxValue)
                        memo[start] = Math.Min(memo[start], 1 + dd);
                }
            }
            return memo[start];
        }
        return dfs(0);
    }
}
