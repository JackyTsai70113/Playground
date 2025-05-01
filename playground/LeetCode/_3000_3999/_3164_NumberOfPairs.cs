namespace playground;

public class _3164_NumberOfPairs
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-number-of-good-pairs-ii
    /// </summary>
    public static long NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        var d = new Dictionary<int, int>();
        foreach (var num in nums1)
        {
            for (int x = 1; x * x <= num; x++)
            {
                if (num % x == 0)
                {
                    d[x] = d.ContainsKey(x) ? d[x] + 1 : 1;
                    int y = num / x;
                    if (x != y)
                        d[y] = d.ContainsKey(y) ? d[y] + 1 : 1;
                }
            }
        }
        long res = 0;
        foreach (var num in nums2)
        {
            if (d.ContainsKey(num * k))
                res += d[num * k];
        }
        return res;
    }
}
