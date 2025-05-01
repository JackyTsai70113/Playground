namespace playground.LeetCode._0000_0999;
public class _0076_MinWindow
{
    public static string MinWindow(string s, string t)
    {
        bool Valid(int count)
        {
            return count == t.Length;
        }
        int n = s.Length, count = 0;
        int resL = -1, resR = -1;
        int[] cnt1 = new int[128], cnt2 = new int[128];
        for (int i = 0; i < t.Length; i++)
        {
            cnt2[t[i]]++;
        }
        for (int l = 0, r = 0; r < n; r++)
        {
            // update state by A[r]
            cnt1[s[r]]++;
            if (cnt1[s[r]] <= cnt2[s[r]])
                count++;
            while (l <= r && Valid(count))
            {
                if (resL == -1 || resR - resL >= r - l)
                {
                    resL = l;
                    resR = r;
                }
                // update state by A[l]
                if (cnt1[s[l]] <= cnt2[s[l]])
                    count--;
                cnt1[s[l]]--;
                l++;
            }
        }
        return resL == -1 ? "" : s.Substring(resL, resR - resL + 1);
    }
}