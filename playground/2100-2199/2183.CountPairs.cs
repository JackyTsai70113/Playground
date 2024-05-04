namespace playground;

public class CountPairs2183
{
    /// <summary>
    /// https://leetcode.com/problems/count-array-pairs-divisible-by-k
    /// </summary>
    public static long CountPairs(int[] nums, int k)
    {
        static int gcd(int x, int y)
        {
            return y == 0 ? x : gcd(y, x % y);
        }

        Dictionary<int, int> d = new();
        long res = 0;
        foreach (var num in nums)
        {
            int curGcd = gcd(num, k);
            foreach (var key in d.Keys)
            {
                if ((long)key * curGcd % k == 0)
                    res += d[key];
            }
            d[curGcd] = d.ContainsKey(curGcd) ? d[curGcd] + 1 : 1;
        }
        return res;
    }
}
