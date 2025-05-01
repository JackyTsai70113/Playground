namespace playground;

public class _1915_WonderfulSubstrings
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-wonderful-substrings
    /// </summary>
    public static long WonderfulSubstrings(string word)
    {
        long res = 0;
        int[] count = new int[1024];
        count[0] = 1;
        int mask = 0;
        foreach (var w in word)
        {
            mask ^= 1 << (w - 'a');
            for (int i = 0; i < 10; i++)
            {
                int oneDiff = mask ^ (1 << i);
                res += count[oneDiff];
            }
            res += count[mask]++;
        }
        return res;
    }
}
