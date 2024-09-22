namespace playground._1200_1299;

public class _1208_EqualSubstring
{
    public static int EqualSubstring(string s, string t, int maxCost)
    {
        bool Valid()
        {
            return maxCost >= 0;
        }
        int l = 0, max = 0;
        int n = s.Length;
        for (int r = 0; r < n; r++)
        {
            // update state by A[r]
            maxCost -= Math.Abs(s[r] - t[r]);
            while (l <= r && !Valid())
            {
                // update state by A[l]
                maxCost += Math.Abs(s[l] - t[l]);
                l++;
            }
            if (Valid())
                max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}
