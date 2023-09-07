using System.Linq;

namespace playground.BitManipulation;

public class MinimumIncompatibilityClass
{
    /// <summaryn>
    /// https://leetcode.com/problems/minimum-incompatibility
    /// </summary>
    public static int MinimumIncompatibility(int[] nums, int k)
    {
        int n = nums.Length;
        if (n == k) return 0;
        Array.Sort(nums);
        var memo = new int[1 << n][];
        for (int i = 0; i < 1 << n; i++)
        {
            memo[i] = new int[n];
            Array.Fill(memo[i], int.MaxValue);
        }
        for (int i = 0; i < n; ++i)
        {
            memo[1 << i][i] = 0;
        }

        for (int mask = 0; mask < (1 << n); ++mask)
        {
            var oneIndexs = Enumerable.Range(0, n)
                .Where(idx => (mask & 1 << idx) > 0)
                .ToList();

            if (oneIndexs.Count % (n / k) == 1)
            {
                var ps = Permutations(oneIndexs, 2);
                foreach (var p in ps)
                {
                    int from = p[0], to = p[1];
                    memo[mask][to] = Math.Min(memo[mask][to], memo[mask ^ (1 << to)][from]);
                }
            }
            else
            {
                var cs = Combinations(oneIndexs, 2);
                foreach (var c in cs)
                {
                    int from = c[0], to = c[1];
                    if (nums[from] != nums[to] && memo[mask ^ (1 << to)][from] != int.MaxValue)
                    {
                        memo[mask][to] = Math.Min(memo[mask][to], memo[mask ^ (1 << to)][from] + nums[to] - nums[from]);
                    }
                }
            }
        }
        int res = memo[(1 << n) - 1].Min();
        return res == int.MaxValue ? -1 : res;
    }

    static List<List<int>> Permutations(List<int> nums, int count)
    {
        var combinations = Combinations(nums, count);
        var res = new List<List<int>>();

        foreach (var c in combinations)
        {
            void Backtracking(int start, List<int> cur)
            {
                if (start == cur.Count)
                {
                    res.Add(new List<int>(cur));
                    return;
                }
                for (int i = start; i < cur.Count; ++i)
                {
                    (cur[i], cur[start]) = (cur[start], cur[i]);
                    Backtracking(i + 1, cur);
                    (cur[start], cur[i]) = (cur[i], cur[start]);
                }
            }
            Backtracking(0, c);
        }

        return res;
    }

    static List<List<int>> Combinations(List<int> nums, int count)
    {
        var res = new List<List<int>>();
        void Backtracking(int start, List<int> cur)
        {
            if (cur.Count == count)
            {
                res.Add(new List<int>(cur));
                return;
            }
            for (int i = start; i < nums.Count; ++i)
            {
                cur.Add(nums[i]);
                Backtracking(i + 1, cur);
                cur.RemoveAt(cur.Count - 1);
            }
        }
        Backtracking(0, new List<int>());
        return res;
    }
}
