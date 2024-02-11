namespace playground;

public class SingleNumber0137
{
    /// <summary>
    /// https://leetcode.com/problems/single-number-ii
    /// </summary>
    public static int SingleNumber(int[] nums)
    {
        int res = 0, sum;
        for (int i = 0; i < 32; i++)
        {
            sum = 0;
            foreach (var num in nums)
                sum += num >> i & 1;
            res += sum % 3 << i;
        }
        return res;
    }
}
