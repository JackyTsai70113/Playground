namespace playground;

public class _0003_LengthOfLongestSubstring
{
    public static int LengthOfLongestSubstring(string s)
    {
        bool Valid(int[] cnt, int i)
        {
            return cnt[i] <= 1;
        }
        int n = s.Length;
        int l = 0, max = 0;
        int[] cnt = new int[256];
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            cnt[s[r]]++;
            while (!Valid(cnt, s[r]))
            {
                // update state by A[l]
                cnt[s[l]]--;
                l++;
            }
            if (Valid(cnt, s[r]))
                max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
