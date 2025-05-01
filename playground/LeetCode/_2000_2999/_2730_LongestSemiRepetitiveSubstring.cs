namespace playground.LeetCode._2000_2999;

public class _2730_LongestSemiRepetitiveSubstring
{
    public static int LongestSemiRepetitiveSubstring(string s)
    {
        static bool Valid(int count)
        {
            return count <= 1;
        }
        int n = s.Length, l = 0, max = 0;
        int count = 0;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            if (l < r && s[r] == s[r - 1])
                count++;
            while (l < r && !Valid(count))
            {
                // update state by A[l]
                if (s[l] == s[l + 1])
                    count--;
                l++;
            }
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
