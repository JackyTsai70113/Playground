namespace playground.Mathematics;

public class FindPrimePairsClass
{
    /// <summary>
    /// https://leetcode.com/problems/prime-pairs-with-target-sum
    /// </summary>
    public static IList<IList<int>> FindPrimePairs(int n)
    {
        var isPrime = Enumerable.Repeat(true, n).ToArray();
        for (int i = 2; i < n; i++)
        {
            if (!isPrime[i])
                continue;
            for (int j = 2 * i; j < n; j += i)
                isPrime[j] = false;
        }
        var res = new List<IList<int>>();
        for (int i = 2; i <= n / 2; ++i)
            if (isPrime[i] && isPrime[n - i])
                res.Add(new List<int> { i, n - i });
        return res;
    }
}
