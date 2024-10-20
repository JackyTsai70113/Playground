namespace playground._3300_3399;

public class _3325_NumberOfSubstrings
{
    public static int NumberOfSubstrings(string s, int k)
    {
        int res = 0;
        var chs = new int[26];
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            // update state by A[r]
            chs[s[r] - 'a']++;
            while (l <= r && chs[s[r] - 'a'] == k)
            {
                res += s.Length - r;
                // update state by A[l]
                chs[s[l] - 'a']--;
                l++;
            }
        }
        return res;
    }
}
