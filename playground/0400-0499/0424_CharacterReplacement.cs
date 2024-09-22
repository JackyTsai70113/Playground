using System;

namespace playground._0400_0499;

public class _0424_CharacterReplacement
{
    public static int CharacterReplacement(string s, int k)
    {
        bool Valid(int[] cnt)
        {
            int max = 0, count = 0;
            for (int i = 0; i < cnt.Length; i++)
            {
                max = Math.Max(max, cnt[i]);
                count += cnt[i];
            }
            return count - max <= k;
        }
        int l = 0, max = 0;
        int n = s.Length;
        int[] cnt = new int[26];
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            cnt[s[r] - 'A']++;
            while (!Valid(cnt))
            {
                // update state by A[l]
                cnt[s[l] - 'A']--;
                l++;
            }
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
