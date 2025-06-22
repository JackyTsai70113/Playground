using playground.Helpers;

namespace playground.LeetCode._2000_2999;

public class _2709_CanTraverseAllPairs
{
    public static bool CanTraverseAllPairs(int[] nums)
    {
        if (nums.Length == 1) return true;
        int n = nums.Length;
        var index = new Dictionary<int, int>();
        var ds = new DisjointSet(n);
        for (int i = 0; i < n; ++i)
        {
            if (nums[i] == 1) return false;
            for (int p = 2; p * p <= nums[i]; ++p)
            {
                if (nums[i] % p != 0) continue;
                if (index.TryGetValue(p, out var val))
                    ds.Union(val, i);
                else
                    index[p] = i;
                while (nums[i] % p == 0) nums[i] /= p;
            }
            if (nums[i] > 1)
            {
                if (index.TryGetValue(nums[i], out var val))
                    ds.Union(val, i);
                else
                    index[nums[i]] = i;
            }
        }
        return ds.ranks[ds.Find(0)] == n;
    }
}
