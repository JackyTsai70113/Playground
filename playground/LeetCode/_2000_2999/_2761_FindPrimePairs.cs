namespace playground.LeetCode._2000_2999;

public class _2761_FindPrimePairs
{
    /// <summary>
    /// https://leetcode.com/problems/prime-pairs-with-target-sum
    /// </summary>
    public static IList<IList<int>> FindPrimePairs(int n)
    {
        var isPrime = Enumerable.Repeat(true, n).ToArray();
        for (int p = 2; p * p < n; ++p)
        {
            if (!isPrime[p]) continue;
            for (int i = p * 2; i < n; i += p)
                isPrime[i] = false;
        }
        var res = new List<IList<int>>();
        for (int i = 2; i <= n / 2; ++i)
            if (isPrime[i] && isPrime[n - i])
                res.Add(new List<int> { i, n - i });
        return res;
    }
}
