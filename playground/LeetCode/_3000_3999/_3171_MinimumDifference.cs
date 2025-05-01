namespace playground;

public class _3171_MinimumDifference
{
    /// <summary>
    /// https://leetcode.com/problems/find-subarray-with-bitwise-and-closest-to-k
    /// </summary>
    public static int MinimumDifference(int[] nums, int k)
    {
        int[] bits = new int[32];
        int res = int.MaxValue;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            InsertValue(bits, nums[r]);
            int cur = GetValue(bits, r - l + 1);
            while (l < r)
            {
                DeleteValue(bits, nums[l]);
                int cur2 = GetValue(bits, r - l);
                if (Math.Abs(cur - k) >= Math.Abs(cur2 - k))
                {
                    cur = cur2;
                    l++;
                }
                else
                {
                    InsertValue(bits, nums[l]);
                    break;
                }
            }
            res = Math.Min(Math.Abs(cur - k), res);
        }
        return res;
    }

    static int GetValue(int[] bits, int count)
    {
        int res = 0;
        for (int i = 0; i < 32; i++)
        {
            if (bits[i] == count)
                res |= 1 << i;
        }
        return res;
    }

    static void InsertValue(int[] bits, int val)
    {
        for (int i = 0; i < 32; i++)
        {
            if ((val & 1) > 0)
                bits[i]++;
            val >>= 1;
        }
    }

    static void DeleteValue(int[] bits, int val)
    {
        for (int i = 0; i < 32; i++)
        {
            if ((val & 1) > 0)
                bits[i]--;
            val >>= 1;
        }
    }
}
