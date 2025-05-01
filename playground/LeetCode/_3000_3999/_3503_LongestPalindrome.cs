namespace playground._3500_3599;

public class _3503_LongestPalindrome
{
    public static int LongestPalindrome(string s, string t)
    {
        int m = s.Length, n = t.Length;
        int maxLen = 0;

        // 1. 中心擴展法：找 s 中所有 palindrome 長度
        var sPal = GetLeftPalindromeCount(s);
        maxLen = Math.Max(maxLen, sPal.Max());

        // 2. t 中所有 palindrome 長度
        var tPal = GetRightPalindromeCount(t);
        maxLen = Math.Max(maxLen, tPal.Max());

        // 3. 拼接 s suffix + t prefix
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int len = 0;
                int l = i, r = j;
                while (l >= 0 && r < n && s[l] == t[r])
                {
                    len++;
                    l--; r++;
                }

                maxLen = Math.Max(maxLen, len * 2);
                // 加上 s 的右邊 palindrome
                if (i + 1 < m)
                    maxLen = Math.Max(maxLen, len * 2 + sPal[i + 1]);
                // 加上 t 的左邊 palindrome
                if (j - 1 >= 0)
                    maxLen = Math.Max(maxLen, len * 2 + tPal[j - 1]);
            }
        }
        return maxLen;
    }

    /// <summary>
    /// 中心擴展法：找 s 中所有往左 palindrome 長度
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int[] GetLeftPalindromeCount(string s)
    {
        int n = s.Length;
        int[] res = new int[n];
        for (int center = 0; center < n; center++)
        {
            // odd
            int l = center, r = center;
            while (l >= 0 && r < n && s[l] == s[r])
            {
                res[l] = Math.Max(res[l], r - l + 1);
                l--; r++;
            }
            // even
            l = center; r = center + 1;
            while (l >= 0 && r < n && s[l] == s[r])
            {
                res[l] = Math.Max(res[l], r - l + 1);
                l--; r++;
            }
        }
        return res;
    }

    /// <summary>
    /// 中心擴展法：找 s 中所有往右 palindrome 長度
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int[] GetRightPalindromeCount(string s)
    {
        int n = s.Length;
        int[] res = new int[n];
        for (int center = 0; center < n; center++)
        {
            // odd
            int l = center, r = center;
            while (l >= 0 && r < n && s[l] == s[r])
            {
                res[r] = Math.Max(res[r], r - l + 1);
                l--; r++;
            }
            // even
            l = center; r = center + 1;
            while (l >= 0 && r < n && s[l] == s[r])
            {
                res[r] = Math.Max(res[r], r - l + 1);
                l--; r++;
            }
        }
        return res;
    }
}
