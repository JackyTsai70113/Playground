using System;

namespace playground._2000_2099;

public class _2024_MaxConsecutiveAnswers
{
    public static int MaxConsecutiveAnswers(string s, int k)
    {
        bool Valid(int t, int f)
        {
            return Math.Min(t, f) <= k;
        }
        int l = 0, max = 0;
        int n = s.Length, t = 0, f = 0;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            if (s[r] == 'T') t++;
            else f++;
            while (!Valid(t, f))
            {
                // update state by A[l]
                if (s[l] == 'T') t--;
                else f--;
                l++;
            }
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
