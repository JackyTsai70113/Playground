namespace playground;

public class SumOfEncryptedInt3079
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-sum-of-encrypted-integers
    /// </summary>
    public static int SumOfEncryptedInt(int[] nums)
    {
        int res = 0;
        foreach (var num in nums)
        {
            int count = 0, max = 0, temp = 0, n = num;
            while (n > 0)
            {
                max = Math.Max(max, n % 10);
                n /= 10;
                count++;
            }
            while (count > 0)
            {
                temp = temp * 10 + max;
                count--;
            }
            res += temp;
        }
        return res;
    }
}
