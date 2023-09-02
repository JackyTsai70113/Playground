namespace playground.Strings;

public class CountKSubsequencesWithMaxBeautyClass
{
    /// <summary>
    /// https://leetcode.com/problems/count-k-subsequences-of-a-string-with-maximum-beauty
    /// </summary>
    public static int CountKSubsequencesWithMaxBeauty(string s, int k)
    {
        int MOD = (int)(1e9 + 7);
        var memo = new int[26];
        foreach (var c in s)
            memo[c - 'a']++;

        Array.Sort(memo, (x, y) => y - x);

        long res = 1;
        var cnts = new List<int>();
        for (int i = 0; i < memo.Length; ++i)
        {
            if (memo[i] == 0 || cnts.Count >= k && memo[i] != memo[i - 1])
                break;
            cnts.Add(memo[i]);
        }
        if (cnts.Count < k)
            return 0;
        for (int i = 0; i < k; ++i)
            res = res * cnts[i] % MOD;

        int firstLastIndex = cnts.IndexOf(cnts[^1]);
        int nn = cnts.Count - firstLastIndex;
        int kk = k - firstLastIndex;
        for (int j = nn; j > kk; j--)
        {
            res = res * j % MOD;
            res = res / (nn - j + 1) % MOD;
        }
        return (int)res;
    }
}
