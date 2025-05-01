namespace playground.LeetCode._0000_0999;

public class _0514_FindRotateSteps
{
    /// <summary>
    /// https://leetcode.com/problems/freedom-trail
    /// </summary>
    public static int FindRotateSteps(string ring, string key)
    {
        int r = ring.Length, k = key.Length;
        var pos = new List<int>[26];
        for (int i = 0; i < r; i++)
        {
            if (pos[ring[i] - 'a'] == null) pos[ring[i] - 'a'] = new();
            pos[ring[i] - 'a'].Add(i);
        }
        int[] memo = new int[r], memo2 = new int[r];
        for (int i = k - 1; i >= 0; i--)
        {
            Array.Fill(memo2, int.MaxValue);
            for (int j = 0; j < r; j++)
            {
                foreach (var next in pos[key[i] - 'a'])
                {
                    var dist = Math.Abs(j - next);
                    memo2[j] = Math.Min(memo2[j], Math.Min(dist, r - dist) + memo[next]);
                }
            }
            (memo, memo2) = (memo2, memo);
        }
        return memo[0] + k;
    }
}
