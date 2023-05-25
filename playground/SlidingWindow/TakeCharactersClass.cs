namespace playground.SlidingWindow;

public class TakeCharactersClass
{
    public static int TakeCharacters(string s, int k)
    {
        int n = s.Length, res = int.MaxValue;
        var cnt = new int[3];
        foreach (var c in s)
            cnt[c - 'a']++;
        foreach (var a in cnt)
        {
            if (a < k)
                return -1;
        }
        for (int l = 0, r = 0; l < n; ++l)
        {
            while (r < n && cnt[s[r] - 'a'] > k) --cnt[s[r++] - 'a'];
            res = Math.Min(res, n - r + l);
            ++cnt[s[l] - 'a'];
        }
        return res == int.MaxValue ? -1 : res;
    }
}
