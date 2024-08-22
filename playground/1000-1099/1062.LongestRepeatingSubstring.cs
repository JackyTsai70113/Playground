namespace playground;

public class LongestRepeatingSubstring1062
{
    public static int LongestRepeatingSubstring(string s)
    {
        int n = s.Length, max = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int l = i, r = j;
                while (r < n && s[l] == s[r])
                {
                    l++;
                    r++;
                }
                max = Math.Max(max, r - j);
            }
        }
        return max;
    }
}
