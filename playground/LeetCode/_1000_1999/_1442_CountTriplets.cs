namespace playground;

public class _1442_CountTriplets
{
    /// <summary>
    /// https://leetcode.com/problems/count-triplets-that-can-form-two-arrays-of-equal-xor
    /// </summary>
    public static int CountTriplets(int[] arr)
    {
        var d = new Dictionary<int, (int count, int sum)>();
        d[0] = (1, 0);
        int xor = 0, res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            xor ^= arr[i];
            if (!d.ContainsKey(xor))
                d[xor] = (0, 0);
            res += (d[xor].count) * i - d[xor].sum;
            d[xor] = (d[xor].count + 1, d[xor].sum + i + 1);
        }
        return res;
    }
}
