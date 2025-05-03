namespace playground.LeetCode._0000_0999;

public class _0567_CheckInclusion
{
    public static bool CheckInclusion(string s1, string s2)
    {
        if (s2.Length < s1.Length)
            return false;
        var cnt = new int[26];
        foreach (var c in s1)
        {
            cnt[c - 'a']++;
        }
        bool Valid()
        {
            for (int i = 0; i < 26; i++)
            {
                if (cnt[i] != 0)
                    return false;
            }
            return true;
        }
        for (int l = 0, r = 0; r < s2.Length; r++)
        {
            // update state by A[r]
            cnt[s2[r] - 'a']--;
            if (r >= s1.Length - 1)
            {
                if (Valid())
                    return true;
                // update state by A[l]
                cnt[s2[l] - 'a']++;
                l++;
            }
        }
        return false;
    }
}