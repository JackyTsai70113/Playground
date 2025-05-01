namespace playground.LeetCode._0000_0999;

public class _0728_SelfDividingNumbers
{
    /// <summary>
    /// https://leetcode.com/problems/self-dividing-numbers
    /// </summary>
    public static IList<int> SelfDividingNumbers(int left, int right)
    {
        var l = new List<int>();
        for (int i = left, n; i <= right; i++)
        {
            for (n = i; n > 0; n /= 10)
                if (n % 10 == 0 || i % (n % 10) != 0) break;
            if (n == 0) l.Add(i);
        }
        return l;
    }
}
