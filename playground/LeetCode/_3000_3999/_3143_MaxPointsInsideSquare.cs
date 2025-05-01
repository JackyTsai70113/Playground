namespace playground;

public class _3143_MaxPointsInsideSquare
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-points-inside-the-square
    /// </summary>
    public static int MaxPointsInsideSquare(int[][] points, string s)
    {
        bool IsValid(int m)
        {
            var seen = new bool[26];
            for (int i = 0; i < points.Length; i++)
            {
                if (Math.Abs(points[i][0]) <= m && Math.Abs(points[i][1]) <= m)
                {
                    if (!seen[s[i] - 'a'])
                        seen[s[i] - 'a'] = true;
                    else
                        return false;
                }
            }
            return true;
        }
        int l = 0, r = 1000000000;
        while (l < r)
        {
            int m = l + (r - l + 1) / 2;
            if (IsValid(m))
            {
                l = m;
            }
            else
            {
                r = m - 1;
            }
        }
        int count = 0;
        for (int i = 0; i < points.Length; i++)
        {
            if (Math.Abs(points[i][0]) <= l && Math.Abs(points[i][1]) <= l)
                count++;
        }
        return count;
    }
}
