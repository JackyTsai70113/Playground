namespace playground;

public class _1930_CountPalindromicSubsequence
{
    public static int CountPalindromicSubsequence(string s)
    {
        var res = 0;
        var dp1 = new bool[26];
        var dp2 = new bool[26, 26];
        var dp3 = new bool[26, 26, 26];
        for (int i = 0; i < s.Length; ++i)
        {
            var idx = s[i] - 'a';
            for (int j = 0; j < 26; ++j)
            {
                if (dp2[idx, j] && !dp3[idx, j, idx])
                {
                    res++; dp3[idx, j, idx] = true;
                }
            }

            for (int j = 0; j < 26; ++j)
            {
                if (dp1[j])
                    dp2[j, idx] = true;
            }
            dp1[idx] = true;
        }
        return res;
    }
}
