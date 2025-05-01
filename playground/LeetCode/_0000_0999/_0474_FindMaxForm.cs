namespace playground.LeetCode._0000_0999;

public class _0474_FindMaxForm
{
    /// <summary>
    /// https://leetcode.com/problems/ones-and-zeroes
    /// </summary>
    public static int FindMaxForm(string[] strs, int m, int n)
    {
        (int zeros, int ones)[] arr = strs.Select(s =>
        {
            int zerosCount = 0;
            foreach (var c in s)
                if (c == '0') zerosCount++;
            return (zerosCount, s.Length - zerosCount);
        }).ToArray();
        int[,,] memo = new int[strs.Length, m + 1, n + 1];
        for (int i = 0; i < strs.Length; i++)
        {
            for (int j = 0; j <= m; j++)
            {
                for (int k = 0; k <= n; k++)
                {
                    memo[i, j, k] = -1;
                }
            }
        }
        int dfs(int i, int zeros, int ones)
        {
            if (i == arr.Length) return 0;
            if (memo[i, zeros, ones] != -1)
                return memo[i, zeros, ones];
            int exclude = dfs(i + 1, zeros, ones);
            if (arr[i].zeros > zeros || arr[i].ones > ones)
                return exclude;
            var include = 1 + dfs(i + 1, zeros - arr[i].zeros, ones - arr[i].ones);
            return memo[i, zeros, ones] = Math.Max(exclude, include);

        }
        return dfs(0, m, n);
    }
}
