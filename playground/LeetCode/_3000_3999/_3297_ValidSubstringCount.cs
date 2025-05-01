namespace playground;

public class _3297_ValidSubstringCount
{
    public static long ValidSubstringCount(string w1, string w2)
    {
        long res = 0;
        int n = w1.Length, k = w2.Length;
        var cnt = new int[26];
        for (int i = 0; i < k; i++)
        {
            cnt[w2[i] - 'a']++;
        }
        for (int l = 0, r = 0; r < n; r++)
        {
            if (cnt[w1[r] - 'a']-- > 0)
            {
                k--;
            }
            while (k == 0 && cnt[w1[l] - 'a'] < 0)
                cnt[w1[l++] - 'a']++;
            if (k == 0)
                res += l + 1;
        }
        return res;
    }
}
