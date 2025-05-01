namespace playground._0400_0499;

public class _0438_FindAnagrams
{
    public static IList<int> FindAnagrams(string s, string p)
    {
        int k = 0;
        bool Valid()
        {
            return k == p.Length;
        }
        int[] cnt = new int[s.Length];
        List<int> res = new();
        foreach (var c in p)
        {
            cnt[c - 'a']++;
        }
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            // update state by A[r]
            if (--cnt[s[r] - 'a'] == 0)
                k++;
            if (r >= p.Length - 1)
            {
                if (Valid())
                    res.Add(l);
                // update state by A[l]
                if (cnt[s[l] - 'a']++ == 0)
                    k--;
                l++;
            }
        }
        return res;
    }
}
