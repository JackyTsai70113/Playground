namespace playground.LeetCode._0000_0999;

/// <summary>
/// https://leetcode.com/problems/random-pick-with-weight
/// </summary>
public class _0528_PickIndex
{
    private readonly List<int> presum = new();
    private readonly Random random = new();

    public _0528_PickIndex(int[] w)
    {
        int sum = 0;
        foreach (var weight in w)
        {
            sum += weight;
            presum.Add(sum);
        }
    }

    public int PickIndex()
    {
        int num = random.Next(presum[^1]) + 1;
        int l = 0, r = presum.Count;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (presum[m] >= num)
                r = m;
            else
                l = m + 1;
        }
        return l;
    }
}
