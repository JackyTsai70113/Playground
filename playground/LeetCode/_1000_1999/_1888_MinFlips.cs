namespace playground_1800_1899;

public class _1888_MinFlips
{
    public static int MinFlips(string s)
    {
        int n = s.Length, count = 0, min = s.Length;
        for (int l = 0, r = 0; r < n * 2; r++)
        {
            if (s[r % n] - '0' == r % 2)
                count++;
            if (r >= n - 1)
            {
                min = Math.Min(min, Math.Min(count, n - count));
                if (s[l % n] - '0' == l % 2)
                    count--;
                l++;
            }
        }
        return min;
    }
}
